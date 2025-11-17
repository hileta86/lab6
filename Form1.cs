using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int N = 1; 
        int i = 0;
        int j = 0;
        int Change;
        double[,] A = new double[6, 6]; 
        double[] B = new double[6]; 
        double[] X = new double[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void Decomp(int N, ref int Change)
        {
            int i, j, k;
            double R, L, U;

            Change = 1;

            R = Math.Abs(A[1, 1]);
            for (j = 2; j <= N; j++)
            {
                if (Math.Abs(A[j, 1]) >= R)
                {
                    Change = j;
                    R = Math.Abs(A[j, 1]);
                }
            }

            if (R <= 1e-7)
            {
                MessageBox.Show("Система вироджена");
                return;
            }

            if (Change != 1)
            {
                for (i = 1; i <= N; i++)
                {
                    R = A[Change, i];
                    A[Change, i] = A[1, i];
                    A[1, i] = R;
                }
            }

            for (i = 2; i <= N; i++)
            {
                A[1, i] = A[1, i] / A[1, 1];
            }

            for (i = 2; i <= N; i++)
            {
                for (k = i; k <= N; k++)
                {
                    R = 0.0;
                    for (j = 1; j <= i - 1; j++)
                    {
                        R += A[k, j] * A[j, i];
                    }
                    A[k, i] = A[k, i] - R;
                }

                if (Math.Abs(A[i, i]) <= 1e-7)
                {
                    MessageBox.Show("Система вироджена");
                    return;
                }

                for (k = i + 1; k <= N; k++)
                {
                    R = 0.0;
                    for (j = 1; j <= i - 1; j++)
                    {
                        R += A[i, j] * A[j, k];
                    }
                    A[i, k] = (A[i, k] - R) / A[i, i];
                }
            }

            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                {
                    C_matrix_dgv.Rows[i].Cells[j].Value = Convert.ToString(A[i + 1, j + 1]);
                }
        }

        private void Solve(int Change, int N)
        {
            int i, j;
            double R;

            if (Change != 1)
            {
                R = B[Change];
                B[Change] = B[1];
                B[1] = R;
            }

            B[1] = B[1] / A[1, 1];

            for (i = 2; i <= N; i++)
            {
                R = 0.0;
                for (j = 1; j <= i - 1; j++)
                {
                    R += A[i, j] * B[j];
                }
                B[i] = (B[i] - R) / A[i, i];
            }

            X[N] = B[N];

            for (i = 1; i <= N - 1; i++)
            {
                R = 0.0;
                for (j = N + 1 - i; j <= N; j++)
                {
                    R += A[N - i, j] * X[j];   
                }
                X[N - i] = B[N - i] - R;
            }
        }

        private void Gauss(int N)
        {
            int i, j, k;
            double R;

            if (N == 1)
            {
                if (Math.Abs(A[1, 1]) < 1e-7)
                {
                    MessageBox.Show("Система є виродженою");
                    return;
                }
                X[1] = B[1] / A[1, 1];
                return;
            }

            for (i = 1; i <= N - 1; i++)
            {
                k = i;
                R = Math.Abs(A[i, i]);
                for (j = i + 1; j <= N; j++)
                {
                    if (Math.Abs(A[j, i]) >= R)
                    {
                        k = j;
                        R = Math.Abs(A[j, i]);
                    }
                }

                if (R <= 1e-7)
                {
                    MessageBox.Show("Система є виродженою");
                    return;
                }

                if (k != i)
                {
                    R = B[k];
                    B[k] = B[i];
                    B[i] = R;

                    for (j = i; j <= N; j++)
                    {
                        R = A[k, j];
                        A[k, j] = A[i, j];
                        A[i, j] = R;
                    }
                }

                R = A[i, i];
                B[i] = B[i] / R;
                for (j = i; j <= N; j++)
                {
                    A[i, j] = A[i, j] / R;
                }

                for (k = i + 1; k <= N; k++)
                {
                    R = A[k, i];
                    B[k] = B[k] - R * B[i];
                    A[k, i] = 0.0;
                    for (j = i + 1; j <= N; j++)
                    {
                        A[k, j] = A[k, j] - R * A[i, j];
                    }
                }
            }

            if (Math.Abs(A[N, N]) <= 1e-7)
            {
                MessageBox.Show("Система є виродженою");
                return;
            }

            X[N] = B[N] / A[N, N];

            for (i = N - 1; i >= 1; i--)
            {
                R = B[i];
                for (j = i + 1; j <= N; j++)
                {
                    R = R - A[i, j] * X[j];
                }
                X[i] = R;
            }

            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                    C_matrix_dgv.Rows[i].Cells[j].Value = A[i + 1, j + 1];
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            X_vector_dgv.ReadOnly = true; 
            A_matrix_dgv.AllowUserToAddRows = false;
            B_vector_dgv.AllowUserToAddRows = false;
            X_vector_dgv.AllowUserToAddRows = false;
            A_matrix_dgv.ColumnCount = 1;
            A_matrix_dgv.RowCount = 1;
            X_vector_dgv.ColumnCount = 1;
            X_vector_dgv.RowCount = 1;
            B_vector_dgv.ColumnCount = 1;
            B_vector_dgv.RowCount = 1;
        }

        private void NUD_rozmir_ValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt16(NUD_rozmir.Value);
            A_matrix_dgv.RowCount = N;
            A_matrix_dgv.ColumnCount = N;
            X_vector_dgv.RowCount = N;
            B_vector_dgv.RowCount = N;
            C_matrix_dgv.RowCount = N;
            C_matrix_dgv.ColumnCount = N;
        }

        private void BСreateGrid_Click(object sender, EventArgs e)
        {
            bool exc_A = false;
            bool exc_B = false;

            for (i = 1; i <= N; i++)
                for (j = 1; j <= N; j++)
                {
                    try
                    {
                        A[i, j] = Convert.ToDouble(A_matrix_dgv[j - 1, i - 1].Value);
                    }
                    catch
                    {
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Red;
                        exc_A = true;
                    }
                }

            for (j = 0; j < N; j++)
            {
                try
                {
                    B[j + 1] = Convert.ToDouble(B_vector_dgv[0, j].Value);
                }
                catch
                {
                    B_vector_dgv[0, j].Style.ForeColor = Color.Red;
                    exc_B = true;
                }
            }

            if (exc_A || exc_B)
            {
                MessageBox.Show("Помилка введення!");
                return;
            }

            if (cbMethod.SelectedIndex == 0)     
            {
                Decomp(N, ref Change);
                Solve(Change, N);
            }
            else                                 
            {
                Gauss(N);
            }

            {
                for (i = 0; i < N; i++)
                    X_vector_dgv[0, i].Value = X[i + 1].ToString();

                MessageBox.Show("Розв'язок знайдено");
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                {
                    A_matrix_dgv[j, i].Value = "";
                    C_matrix_dgv[j, i].Value = "";
                }
            for (j = 0; j < N; j++)
            {
                B_vector_dgv[0, j].Value = "";
                X_vector_dgv[0, j].Value = "";
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void A_matrix_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            A_matrix_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }

        private void B_vector_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            B_vector_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }
    }
}
