using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Data;
using MySql.Data.MySqlClient;


namespace timerMinutesPrueba
{
    public partial class StopwatchForm : Form
    {
        MySqlConnection conn;
        String[] selectedTime = { "0", "0", "0", "0" };
        string zero = "00:00:00.00";
        int hora;
        int min;
        int seg;
        int mils;
        public StopwatchForm()
        {
            InitializeComponent();
            stopwatch = new System.Diagnostics.Stopwatch();
            label5.Text = zero;
            label5.ForeColor = Color.LightGray;


            string connstring = @"server=127.0.0.1;
                                userid=root;
                                password=1121rsn;
                                database=stopwatch";
            conn = new MySqlConnection(connstring);
            conn.Open();

            //string query = "SELECT * FROM tiempos;";
            //MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "tiempos");
            //DataTable dt = ds.Tables["tiempos"];




            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        Console.Write(row[col] + "\t");
            //    }

            //    Console.Write("\n");
            //}

        }

        private void start_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Stoptimer();

        }
        private void miliseconds_Tick(object sender, EventArgs e)
        {

            TimeSpan ts = stopwatch.Elapsed;
            ts = ts.Add(new TimeSpan(
                0,
                Int32.Parse(selectedTime[0]),
                Int32.Parse(selectedTime[1]),
                Int32.Parse(selectedTime[2]),
                Int32.Parse(selectedTime[3])
            ));
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            label5.Text = elapsedTime.ToString();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            RestartTimer();
            label5.Text = zero;
        }

        private void Stoptimer()
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                miliseconds.Stop();
                label5.ForeColor = Color.FromArgb(185, 62, 62);
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                row.Cells[2].Value = label5.Text;
            }
        }
        private void StartTimer()
        {
            stopwatch.Start();
            miliseconds.Start();
            label5.ForeColor = Color.FromArgb(80, 171, 47);
        }

        private void RestartTimer()
        {
            stopwatch.Reset();
            label5.ForeColor = Color.LightGray;
        }

        private void Form_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'x')
            {
                Stoptimer();
            }
            if (e.KeyChar == 'z')
            {
                StartTimer();
            }
            if (e.KeyChar == 'c')
            {
                RestartTimer();
            }
            //Console.WriteLine(e.KeyChar);
        }

        private void UpdateRow(DataGridViewSelectedRowCollection rows)
        {
            //Console.WriteLine(rows[0].Cells[0].Value);//Para que no de error hay poner el "datagridview.selectionmode" en "fullrowselected"
            var rowId = rows[0].Cells[0].Value;
            var rowName = rows[0].Cells[1].Value;
            var rowTime = rows[0].Cells[2].Value;
            string updateString = "UPDATE tiempos SET nombre='" + rowName + "',tiempo='" + rowTime + "' WHERE tiempos.idtiempos='" + rowId + "'";
            MySqlCommand update = new MySqlCommand(updateString, conn);
            update.ExecuteNonQuery();

            foreach (DataGridViewRow row in rows)
            {
                var idRow = row.Cells[0].Value;
            }


            DisplayData();
        }
        private void UpdateAll()
        {
            //https://stackoverflow.com/questions/1361340/how-can-i-do-insert-if-not-exists-in-mysql

            Console.WriteLine("Numero de filas en dtagridview:" + dataGridView1.Rows.Count);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Console.WriteLine("id row:" + row.Cells[0].Value);
                var rowId = row.Cells[0].Value;
                var rowName = row.Cells[1].Value;
                var rowTime = row.Cells[2].Value;
                string idString = Convert.ToString(rowId);
                string insertString = "REPLACE INTO tiempos SET nombre='" + rowName + "',tiempo='" + rowTime + "'";
                Console.WriteLine("ROWID TYPE" + idString.GetType());
                Console.WriteLine("DBNull-->" + DBNull.Value);
                if (rowId != System.DBNull.Value)
                {
                    if (rowId == null || Convert.ToInt32(rowId) <= 0 || idString == "")
                    {
                        insertString = "REPLACE INTO tiempos SET nombre='" + rowName + "',tiempo='" + rowTime + "'";
                    }
                    else
                    {
                        insertString = "REPLACE INTO tiempos SET idtiempos=" + rowId + ", nombre='" + rowName + "',tiempo='" + rowTime + "'";
                    }
                }

                if (rowTime != null && rowName != null && rowTime != "" && rowName != "")
                {
                    //string insertString = "INSERT INTO tiempos (nombre,tiempo) VALUES ('" + rowName + "','" + rowTime + "')";
                    //string insertString = "REPLACE INTO tiempos SET idtiempos="+rowId+", nombre='" + rowName + "',tiempo='" + rowTime + "'";
                    MySqlCommand insertCommand = new MySqlCommand(insertString, conn);
                    insertCommand.ExecuteNonQuery();
                }

                //ESTA HACIENDO INSERT DE TODAS LAS ROWS DEL DATAGRIDVIEW INCLUSO LA QUE ESTÁ EN BLANCO, POR ESO DA ERROR;
            }
            DisplayData();
        }



        private void DisplayData()
        {
            string query = "SELECT * FROM tiempos;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void DeleteRow(DataGridViewSelectedRowCollection rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                var idRow = row.Cells[0].Value;
                if (idRow != null)
                {
                    string deleteString = "DELETE FROM tiempos WHERE idtiempos=" + idRow;
                    MySqlCommand delete = new MySqlCommand(deleteString, conn);
                    delete.ExecuteNonQuery();
                }

            }
            DisplayData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'stopwatchDataSet1.tiempos' Puede moverla o quitarla según sea necesario.
            this.tiemposTableAdapter1.Fill(this.stopwatchDataSet1.tiempos);
            // TODO: esta línea de código carga datos en la tabla 'stopwatchDataSet.tiempos' Puede moverla o quitarla según sea necesario.
            this.tiemposTableAdapter.Fill(this.stopwatchDataSet.tiempos);

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //UpdateRow(dataGridView1.SelectedRows);
            //Console.WriteLine("cells->"+dataGridView1.SelectedCells.Count);
            //Console.WriteLine("rows->"+dataGridView1.SelectedRows.Count);

        }


        private void saveAll_Click(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteRow(dataGridView1.SelectedRows);
        }

        
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Este reset es para que al cambiar de fila en el datagridview no se añada un tiempo al otro
            //porque en el miliseconds_tick el tiempo sigue desde el tiempo seleccionado en el datagridview
            stopwatch.Reset();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[2].Value != DBNull.Value)
                {
                    Console.WriteLine(row.Cells[2].Value);
                    label5.Text = row.Cells[2].Value.ToString();
                    selectedTime = row.Cells[2].Value.ToString().Split('.', ':');
                    foreach (var split in selectedTime)
                    {
                        Console.WriteLine(split);
                    }
                }
            }
        }
    }
}
