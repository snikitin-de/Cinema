using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Cinema.Properties.Settings.CinemaConnectionString"].ConnectionString);

        static void connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            var outputFromStoredProcedure = MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soldTicketsDataSet.Продажа_билетов". При необходимости она может быть перемещена или удалена.
            this.продажа_билетовTableAdapter.Fill(this.soldTicketsDataSet.Продажа_билетов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ticketDataSet.Билет". При необходимости она может быть перемещена или удалена.
            this.билетTableAdapter.Fill(this.ticketDataSet.Билет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "countOfTicketDataSet.Кол_билетов_зала". При необходимости она может быть перемещена или удалена.
            this.кол_билетов_залаTableAdapter.Fill(this.countOfTicketDataSet.Кол_билетов_зала);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hallWithoutFilmDataSet.Залы_без_фильмов". При необходимости она может быть перемещена или удалена.
            this.залы_без_фильмовTableAdapter.Fill(this.hallWithoutFilmDataSet.Залы_без_фильмов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "topFilmDataSet.Топ_фильмов". При необходимости она может быть перемещена или удалена.
            this.топ_фильмовTableAdapter.Fill(this.topFilmDataSet.Топ_фильмов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "topClientDataSet.Топ_клиентов". При необходимости она может быть перемещена или удалена.
            this.топ_клиентовTableAdapter.Fill(this.topClientDataSet.Топ_клиентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "topCashierDataSet.Топ_кассиров". При необходимости она может быть перемещена или удалена.
            this.топ_кассировTableAdapter.Fill(this.topCashierDataSet.Топ_кассиров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter1.Fill(this.postDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "showFilmDataSet.Показывает_фильм". При необходимости она может быть перемещена или удалена.
            this.показывает_фильмTableAdapter.Fill(this.showFilmDataSet.Показывает_фильм);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workerHallDataSet.Сотрудники_зала". При необходимости она может быть перемещена или удалена.
            this.сотрудники_залаTableAdapter.Fill(this.workerHallDataSet.Сотрудники_зала);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "showingFilmDataSet.Показ_фильма". При необходимости она может быть перемещена или удалена.
            this.показ_фильмаTableAdapter.Fill(this.showingFilmDataSet.Показ_фильма);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lisenseListDataSet.Лицензия". При необходимости она может быть перемещена или удалена.
            this.лицензияTableAdapter.Fill(this.lisenseListDataSet.Лицензия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sessionInHallDataSet.Сеансы_зала". При необходимости она может быть перемещена или удалена.
            this.сеансы_залаTableAdapter.Fill(this.sessionInHallDataSet.Сеансы_зала);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sessionDataSet.Сеанс". При необходимости она может быть перемещена или удалена.
            this.сеансTableAdapter.Fill(this.sessionDataSet.Сеанс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmDataSet.Фильм". При необходимости она может быть перемещена или удалена.
            this.фильмTableAdapter.Fill(this.filmDataSet.Фильм);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hallNumberDataSet.Зал". При необходимости она может быть перемещена или удалена.
            this.залTableAdapter1.Fill(this.hallNumberDataSet.Зал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "placeInHallDataSet.Места_в_зале". При необходимости она может быть перемещена или удалена.
            this.места_в_залеTableAdapter.Fill(this.placeInHallDataSet.Места_в_зале);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hallDataSet.Зал". При необходимости она может быть перемещена или удалена.
            this.залTableAdapter.Fill(this.hallDataSet.Зал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workerDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.workerDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.equipmentDataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "licenseDataSet.Приобретение_лицензии". При необходимости она может быть перемещена или удалена.
            this.приобретение_лицензииTableAdapter.Fill(this.licenseDataSet.Приобретение_лицензии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clientDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.clientDataSet.Клиент);

            dtmTimeSession.CustomFormat = "dd.MM.yyyy HH:mm";
            dtmTimeSessionHall.CustomFormat = "dd.MM.yyyy HH:mm";
            dgvwTicket.Columns[2].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
            dgvwSession.Columns[2].DefaultCellStyle.Format = "yyyy";
            dgvwFilm.Columns[1].DefaultCellStyle.Format = "yyyy";
            dgvwShowFilm.Columns[2].DefaultCellStyle.Format = "yyyy";
            dgvwAcquisitionLicense.Columns[2].DefaultCellStyle.Format = "yyyy";
            dgvwShowingFilm.Columns[2].DefaultCellStyle.Format = "yyyy";
            dgvwSoldTickets.Columns[1].DefaultCellStyle.Format = "yyyy";
            numYearFilm.Maximum = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearFilm.Value = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearSession.Maximum = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearSession.Value = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearSessionHall.Maximum = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearSessionHall.Value = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearFilmShowFilm.Maximum = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearFilmShowFilm.Value = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearFilmAcquisitionLicense.Maximum = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearFilmAcquisitionLicense.Value = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearFilmShowing.Maximum = Decimal.Parse(DateTime.Now.Year.ToString());
            numYearFilmShowing.Value = Decimal.Parse(DateTime.Now.Year.ToString());
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
            cboFormatFilm.SelectedIndex = 0;
            cboRating.SelectedIndex = 0;
            cboFormatFilmShowsFilm.SelectedIndex = 0;
            cboRatingFilmShowsFilm.SelectedIndex = 0;
            cboTypeClient.SelectedIndex = 0;
            cboEquipmentFormat.SelectedIndex = 0;
            dtmTimeSession.MaxDate = DateTime.Parse($"{(DateTime.Now.Day + 7).ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()}");
            dtmTimeSession.MinDate = DateTime.Parse($"{DateTime.Now.Day.ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()} {DateTime.Now.Hour}:{DateTime.Now.Minute}");
            dtmTimeSessionHall.MaxDate = DateTime.Parse($"{(DateTime.Now.Day + 7).ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()}");
            dtmTimeSessionHall.MinDate = DateTime.Parse($"{DateTime.Now.Day.ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()} {DateTime.Now.Hour}:{DateTime.Now.Minute}");
            dtmLicenseValidityPeriod.MaxDate = DateTime.Parse($"31.12.2099");
            dtmLicenseValidityPeriod.MinDate = DateTime.Parse($"{DateTime.Now.Day.ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()}");

            /*Фильм по умолчанию*/
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand command = new SqlCommand("SELECT Название_фильма FROM Свободные_места GROUP BY Название_фильма", con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cboNameFilmTicket.Items.Add(reader[0].ToString());
                }

                reader.Close();

                cboNameFilmTicket.SelectedIndex = 0;

                SqlCommand command2 = new SqlCommand($"SELECT Год_выпуска " +
                                                     $"FROM Свободные_места " +
                                                     $"WHERE Название_фильма = '{cboNameFilmTicket.SelectedItem.ToString()}' " +
                                                     $"GROUP BY Год_выпуска", con);

                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    string response = reader2[0].ToString();
                    cboYearFilmTicket.Items.Add(response.Substring(0, response.Length - 8).Remove(0, 6));
                }

                reader2.Close();

                cboYearFilmTicket.SelectedIndex = 0;

                SqlCommand command4 = new SqlCommand($"SELECT Время_сеанса " +
                                                  $"FROM Свободные_места " +
                                                  $"WHERE Название_фильма = '{cboNameFilmTicket.SelectedItem.ToString()}' " +
                                                  $"GROUP BY Время_сеанса", con);

                SqlDataReader reader4 = command4.ExecuteReader();

                while (reader4.Read())
                {
                    cboDateSessionTicket.Items.Add(reader4[0].ToString().Remove(reader4[0].ToString().Length - 3, 3));
                }

                reader4.Close();

                cboDateSessionTicket.SelectedIndex = 0;

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand command3 = new SqlCommand($"SELECT Номер_зала " +
                                                    $"FROM Свободные_места " +
                                                    $"WHERE Название_фильма = '{cboNameFilmTicket.SelectedItem.ToString()}' AND " +
                                                    $"Время_сеанса = '{cboDateSessionTicket.SelectedItem.ToString()}' AND Год_выпуска = " +
                                                    $"'{cboYearFilmTicket.SelectedItem.ToString()}' " +
                                                    $"GROUP BY Номер_зала", con);

                SqlDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {
                    cboNumHallTicket.Items.Add(reader3[0].ToString());
                }

                reader3.Close();

                cboNumHallTicket.SelectedIndex = 0;

                PlaceHall();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                txtFullName.CausesValidation = true;
                txtDiscountCard.CausesValidation = true;
                txtEmail.CausesValidation = true;
                txtmPhone.CausesValidation = true;
                cboTypeClient.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_Client @ФИО_клиента, @Тип_клиента, @Скидочная_карта, @Скидка, @Email, @Телефон";
                    cmd.Parameters.Add("@ФИО_клиента", SqlDbType.NVarChar).Value = txtFullName.Text;
                    cmd.Parameters.Add("@Тип_клиента", SqlDbType.NVarChar).Value = cboTypeClient.SelectedItem.ToString();
                    cmd.Parameters.Add("@Скидочная_карта", SqlDbType.Int).Value = txtDiscountCard.Text;
                    cmd.Parameters.Add("@Скидка", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@Телефон", SqlDbType.NVarChar).Value = txtmPhone.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.клиентTableAdapter.Fill(this.clientDataSet.Клиент);
                }

                txtFullName.CausesValidation = false;
                txtDiscountCard.CausesValidation = false;
                txtEmail.CausesValidation = false;
                txtmPhone.CausesValidation = false;
                cboTypeClient.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                txtFullName.CausesValidation = true;
                txtDiscountCard.CausesValidation = true;
                txtEmail.CausesValidation = true;
                txtmPhone.CausesValidation = true;
                cboTypeClient.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Update_client @ФИО_клиента, @Тип_клиента, @Скидка, @Email, @Телефон";
                    cmd.Parameters.Add("@ФИО_клиента", SqlDbType.NVarChar).Value = txtFullName.Text;
                    cmd.Parameters.Add("@Тип_клиента", SqlDbType.NVarChar).Value = cboTypeClient.SelectedItem.ToString();
                    cmd.Parameters.Add("@Скидка", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@Телефон", SqlDbType.NVarChar).Value = txtmPhone.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.клиентTableAdapter.Fill(this.clientDataSet.Клиент);
                }

                txtFullName.CausesValidation = false;
                txtDiscountCard.CausesValidation = false;
                txtEmail.CausesValidation = false;
                txtmPhone.CausesValidation = false;
                cboTypeClient.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                txtFullName.CausesValidation = true;
                txtmPhone.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_client @ФИО_клиента, @Телефон";
                    cmd.Parameters.Add("@ФИО_клиента", SqlDbType.NVarChar).Value = txtFullName.Text;
                    cmd.Parameters.Add("@Телефон", SqlDbType.NVarChar).Value = txtmPhone.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.клиентTableAdapter.Fill(this.clientDataSet.Клиент);
                }

                txtFullName.CausesValidation = false;
                txtmPhone.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtFullName.Text = dgvwClient.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cboTypeClient.SelectedItem = dgvwClient.Rows[e.RowIndex].Cells[1].Value;
                        txtDiscountCard.Text = dgvwClient.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtEmail.Text = dgvwClient.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtmPhone.Text = dgvwClient.Rows[e.RowIndex].Cells[5].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddPost_Click(object sender, EventArgs e)
        {
            try
            {
                txtTitlePost.CausesValidation = true;
                txtDescriptionPost.CausesValidation = true;
                txtSalary.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_Post @Название_должности, @Описание_должности, @Зарплата";
                    cmd.Parameters.Add("@Название_должности", SqlDbType.NVarChar).Value = txtTitlePost.Text;
                    cmd.Parameters.Add("@Описание_должности", SqlDbType.NVarChar).Value = txtDescriptionPost.Text;
                    cmd.Parameters.Add("@Зарплата", SqlDbType.Money).Value = Decimal.Parse(txtSalary.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.должностьTableAdapter1.Fill(this.postDataSet.Должность);
                }

                txtTitlePost.CausesValidation = false;
                txtDescriptionPost.CausesValidation = false;
                txtSalary.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdatePost_Click(object sender, EventArgs e)
        {
            try
            {
                txtTitlePost.CausesValidation = true;
                txtDescriptionPost.CausesValidation = true;
                txtSalary.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Update_Post @Название_должности, @Описание_должности, @Зарплата";
                    cmd.Parameters.Add("@Название_должности", SqlDbType.NVarChar).Value = txtTitlePost.Text;
                    cmd.Parameters.Add("@Описание_должности", SqlDbType.NVarChar).Value = txtDescriptionPost.Text;
                    cmd.Parameters.Add("@Зарплата", SqlDbType.Money).Value = Decimal.Parse(txtSalary.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.должностьTableAdapter1.Fill(this.postDataSet.Должность);
                }

                txtTitlePost.CausesValidation = false;
                txtDescriptionPost.CausesValidation = false;
                txtSalary.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            try
            {
                txtTitlePost.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_Post @Название_должности";
                    cmd.Parameters.Add("@Название_должности", SqlDbType.NVarChar).Value = txtTitlePost.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.должностьTableAdapter1.Fill(this.postDataSet.Должность);
                }

                txtTitlePost.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwPost_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwPost.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtTitlePost.Text = dgvwPost.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtDescriptionPost.Text = dgvwPost.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtSalary.Text = dgvwPost.Rows[e.RowIndex].Cells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                txtEquipmentID.CausesValidation = true;
                txtDescriptionEquipment.CausesValidation = true;
                cboEquipmentFormat.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_equipment @ID_оборудования, @Формат_оборудования, @Описание_оборедования";
                    cmd.Parameters.Add("@ID_оборудования", SqlDbType.Int).Value = txtEquipmentID.Text;
                    cmd.Parameters.Add("@Формат_оборудования", SqlDbType.NVarChar).Value = cboEquipmentFormat.SelectedItem.ToString();
                    cmd.Parameters.Add("@Описание_оборедования", SqlDbType.NVarChar).Value = txtDescriptionEquipment.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.оборудованиеTableAdapter.Fill(this.equipmentDataSet.Оборудование);
                }

                txtEquipmentID.CausesValidation = false;
                txtDescriptionEquipment.CausesValidation = false;
                cboEquipmentFormat.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                txtEquipmentID.CausesValidation = true;
                txtDescriptionEquipment.CausesValidation = true;
                cboEquipmentFormat.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Update_equipment @ID_оборудования, @Формат_оборудования, @Описание_оборедования";
                    cmd.Parameters.Add("@ID_оборудования", SqlDbType.Int).Value = txtEquipmentID.Text;
                    cmd.Parameters.Add("@Формат_оборудования", SqlDbType.NVarChar).Value = cboEquipmentFormat.SelectedItem.ToString();
                    cmd.Parameters.Add("@Описание_оборедования", SqlDbType.NVarChar).Value = txtDescriptionEquipment.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.оборудованиеTableAdapter.Fill(this.equipmentDataSet.Оборудование);
                }

                txtEquipmentID.CausesValidation = false;
                txtDescriptionEquipment.CausesValidation = false;
                cboEquipmentFormat.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                txtEquipmentID.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_equipment @ID_оборудования";
                    cmd.Parameters.Add("@ID_оборудования", SqlDbType.Int).Value = txtEquipmentID.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.оборудованиеTableAdapter.Fill(this.equipmentDataSet.Оборудование);
                }

                txtEquipmentID.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwEquipment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtEquipmentID.Text = dgvwEquipment.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cboEquipmentFormat.SelectedItem = dgvwEquipment.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtDescriptionEquipment.Text = dgvwEquipment.Rows[e.RowIndex].Cells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwShowingFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwShowingFilm.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtEquipmentIDFilm.Text = dgvwShowingFilm.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtNameFilmShowing.Text = dgvwShowingFilm.Rows[e.RowIndex].Cells[1].Value.ToString();
                        numYearFilmShowing.Value = Decimal.Parse(dgvwShowingFilm.Rows[e.RowIndex].Cells[2].Value.ToString().Remove(0, 6).Substring(0, dgvwShowingFilm.Rows[e.RowIndex].Cells[2].Value.ToString().Remove(0, 6).Length - 8));
                        txtNameWorkerShowing.Text = dgvwShowingFilm.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtmPassportShowing.Text = dgvwShowingFilm.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtTitlePostShowing.Text = dgvwShowingFilm.Rows[e.RowIndex].Cells[5].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddShowingFilm_Click(object sender, EventArgs e)
        {
            try
            {
                txtEquipmentIDFilm.CausesValidation = true;
                txtNameFilmShowing.CausesValidation = true;
                txtNameWorkerShowing.CausesValidation = true;
                txtmPassportShowing.CausesValidation = true;
                txtTitlePostShowing.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_showing_a_film @ID_оборудования, @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспорт, @Название_дожности";
                    cmd.Parameters.Add("@ID_оборудования", SqlDbType.Int).Value = int.Parse(txtEquipmentIDFilm.Text);
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilmShowing.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearFilmShowing.Text;
                    cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorkerShowing.Text;
                    cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassportShowing.Text;
                    cmd.Parameters.Add("@Название_дожности", SqlDbType.NVarChar).Value = txtTitlePostShowing.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.показ_фильмаTableAdapter.Fill(this.showingFilmDataSet.Показ_фильма);
                }

                txtEquipmentIDFilm.CausesValidation = false;
                txtNameFilmShowing.CausesValidation = false;
                txtNameWorkerShowing.CausesValidation = false;
                txtmPassportShowing.CausesValidation = false;
                txtTitlePostShowing.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteShowingFilm_Click(object sender, EventArgs e)
        {
            try
            {
                txtEquipmentIDFilm.CausesValidation = true;
                txtNameFilmShowing.CausesValidation = true;
                txtNameWorkerShowing.CausesValidation = true;
                txtmPassportShowing.CausesValidation = true;
                txtTitlePostShowing.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_showing_a_film @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспорт, @ID_оборудования";
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilmShowing.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearFilmShowing.Text;
                    cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorkerShowing.Text;
                    cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassportShowing.Text;
                    cmd.Parameters.Add("@ID_оборудования", SqlDbType.Int).Value = int.Parse(txtEquipmentIDFilm.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.показ_фильмаTableAdapter.Fill(this.showingFilmDataSet.Показ_фильма);
                }

                txtEquipmentIDFilm.CausesValidation = false;
                txtNameFilmShowing.CausesValidation = false;
                txtNameWorkerShowing.CausesValidation = false;
                txtmPassportShowing.CausesValidation = false;
                txtTitlePostShowing.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddLicense_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumLicense.CausesValidation = true;
                txtCostLicense.CausesValidation = true;
                txtDescriptionLicense.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_license @Номер_лицензии, @Стоимость_лицензии, @Описание_лицензии, @Срок_лицензии";
                    cmd.Parameters.Add("@Номер_лицензии", SqlDbType.Int).Value = txtNumLicense.Text;
                    cmd.Parameters.Add("@Стоимость_лицензии", SqlDbType.Money).Value = Decimal.Parse(txtCostLicense.Text);
                    cmd.Parameters.Add("@Описание_лицензии", SqlDbType.NVarChar).Value = txtDescriptionLicense.Text;
                    cmd.Parameters.Add("@Срок_лицензии", SqlDbType.NVarChar).Value = dtmLicenseValidityPeriod.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.лицензияTableAdapter.Fill(this.lisenseListDataSet.Лицензия);
                }

                txtNumLicense.CausesValidation = false;
                txtCostLicense.CausesValidation = false;
                txtDescriptionLicense.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnUpdateLicense_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumLicense.CausesValidation = true;
                txtCostLicense.CausesValidation = true;
                txtDescriptionLicense.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Update_license @Номер_лицензии, @Стоимость_лицензии, @Описание_лицензии, @Срок_лицензии";
                    cmd.Parameters.Add("@Номер_лицензии", SqlDbType.Int).Value = txtNumLicense.Text;
                    cmd.Parameters.Add("@Стоимость_лицензии", SqlDbType.Money).Value = Decimal.Parse(txtCostLicense.Text);
                    cmd.Parameters.Add("@Описание_лицензии", SqlDbType.NVarChar).Value = txtDescriptionLicense.Text;
                    cmd.Parameters.Add("@Срок_лицензии", SqlDbType.NVarChar).Value = dtmLicenseValidityPeriod.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.лицензияTableAdapter.Fill(this.lisenseListDataSet.Лицензия);
                }

                txtNumLicense.CausesValidation = false;
                txtCostLicense.CausesValidation = false;
                txtDescriptionLicense.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteLicense_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumLicense.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_license @Номер_лицензии";
                    cmd.Parameters.Add("@Номер_лицензии", SqlDbType.Int).Value = txtNumLicense.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.лицензияTableAdapter.Fill(this.lisenseListDataSet.Лицензия);
                }

                txtNumLicense.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwLicense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwLicense.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtNumLicense.Text = dgvwLicense.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtCostLicense.Text = dgvwLicense.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtDescriptionLicense.Text = dgvwLicense.Rows[e.RowIndex].Cells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void txtCostLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddAcquisitionLicense_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumAcquisitionLicense.CausesValidation = true;
                txtNameFilmAcquisitionLicense.CausesValidation = true;
                txtNameWorkerAcquisitionLicense.CausesValidation = true;
                txtmPassportWorkerAcquisitionLicense.CausesValidation = true;
                txtTitlePostAcquisitionLicense.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_acquisition_of_a_license @Номер_лицензии, @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспорт, @Название_должности";
                    cmd.Parameters.Add("@Номер_лицензии", SqlDbType.Int).Value = int.Parse(txtNumAcquisitionLicense.Text);
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilmAcquisitionLicense.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearFilmAcquisitionLicense.Text;
                    cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorkerAcquisitionLicense.Text;
                    cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassportWorkerAcquisitionLicense.Text;
                    cmd.Parameters.Add("@Название_должности", SqlDbType.NVarChar).Value = txtTitlePostAcquisitionLicense.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.приобретение_лицензииTableAdapter.Fill(this.licenseDataSet.Приобретение_лицензии);
                }

                txtNumAcquisitionLicense.CausesValidation = false;
                txtNameFilmAcquisitionLicense.CausesValidation = false;
                txtNameWorkerAcquisitionLicense.CausesValidation = false;
                txtmPassportWorkerAcquisitionLicense.CausesValidation = false;
                txtTitlePostAcquisitionLicense.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteAcquisitionLicense_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumAcquisitionLicense.CausesValidation = true;
                txtNameFilmAcquisitionLicense.CausesValidation = true;
                txtNameWorkerAcquisitionLicense.CausesValidation = true;
                txtmPassportWorkerAcquisitionLicense.CausesValidation = true;
                txtTitlePostAcquisitionLicense.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_acquisition_of_a_license @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспорт, @Номер_лицензии";
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilmAcquisitionLicense.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearFilmAcquisitionLicense.Text;
                    cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorkerAcquisitionLicense.Text;
                    cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassportWorkerAcquisitionLicense.Text;
                    cmd.Parameters.Add("@Номер_лицензии", SqlDbType.Int).Value = int.Parse(txtNumAcquisitionLicense.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.приобретение_лицензииTableAdapter.Fill(this.licenseDataSet.Приобретение_лицензии);
                }

                txtNumAcquisitionLicense.CausesValidation = false;
                txtNameFilmAcquisitionLicense.CausesValidation = false;
                txtNameWorkerAcquisitionLicense.CausesValidation = false;
                txtmPassportWorkerAcquisitionLicense.CausesValidation = false;
                txtTitlePostAcquisitionLicense.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwAcquisitionLicense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwAcquisitionLicense.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtNumAcquisitionLicense.Text = dgvwAcquisitionLicense.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtNameFilmAcquisitionLicense.Text = dgvwAcquisitionLicense.Rows[e.RowIndex].Cells[1].Value.ToString();
                        numYearFilmAcquisitionLicense.Value = Decimal.Parse(dgvwAcquisitionLicense.Rows[e.RowIndex].Cells[2].Value.ToString().Remove(0, 6).Substring(0, dgvwAcquisitionLicense.Rows[e.RowIndex].Cells[2].Value.ToString().Remove(0, 6).Length - 8));
                        txtNameWorkerAcquisitionLicense.Text = dgvwAcquisitionLicense.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtmPassportWorkerAcquisitionLicense.Text = dgvwAcquisitionLicense.Rows[e.RowIndex].Cells[4].Value.ToString();
                        txtTitlePostAcquisitionLicense.Text = dgvwAcquisitionLicense.Rows[e.RowIndex].Cells[5].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }


        private void txtEquipmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtEquipmentIDFilm_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumAcquisitionLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtDiscountCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumHallSessionHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtQuantityPlaceHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumHallShowFilm_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumHallPlaceHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumRowPlaceHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumPlaceHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtGroupNumHallPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtGroupNumRowHallPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtGroupQuantityPlaceHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtNumHallWorkerHall_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void OnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in tabFilm.Controls)
                {
                    control.CausesValidation = true;
                }

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_film @Название_фильма, @Год_выпуска, @Режиссёр, @Жанр, @Формат, @Рейтинг";
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilm.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearFilm.Text;
                    cmd.Parameters.Add("@Режиссёр", SqlDbType.NVarChar).Value = txtProducer.Text;
                    cmd.Parameters.Add("@Жанр", SqlDbType.NVarChar).Value = txtGenre.Text;
                    cmd.Parameters.Add("@Формат", SqlDbType.NVarChar).Value = cboFormatFilm.SelectedItem.ToString();
                    cmd.Parameters.Add("@Рейтинг", SqlDbType.NVarChar).Value = cboRating.SelectedItem.ToString();
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.фильмTableAdapter.Fill(this.filmDataSet.Фильм);
                }

                foreach (Control control in tabFilm.Controls)
                {
                    control.CausesValidation = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnUpdateFilm_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in tabFilm.Controls)
                {
                    control.CausesValidation = true;
                }

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Update_film @Название_фильма, @Год_выпуска, @Режиссёр, @Жанр, @Формат, @Рейтинг";
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilm.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearFilm.Text;
                    cmd.Parameters.Add("@Режиссёр", SqlDbType.NVarChar).Value = txtProducer.Text;
                    cmd.Parameters.Add("@Жанр", SqlDbType.NVarChar).Value = txtGenre.Text;
                    cmd.Parameters.Add("@Формат", SqlDbType.NVarChar).Value = cboFormatFilm.SelectedItem.ToString();
                    cmd.Parameters.Add("@Рейтинг", SqlDbType.NVarChar).Value = cboRating.SelectedItem.ToString();
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.фильмTableAdapter.Fill(this.filmDataSet.Фильм);
                }

                foreach (Control control in tabFilm.Controls)
                {
                    control.CausesValidation = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteFilm_Click(object sender, EventArgs e)
        {
            try
            {
                txtNameFilm.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_film @Название_фильма, @Год_выпуска";
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilm.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearFilm.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.фильмTableAdapter.Fill(this.filmDataSet.Фильм);
                }

                txtNameFilm.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwFilm.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtNameFilm.Text = dgvwFilm.Rows[e.RowIndex].Cells[0].Value.ToString();
                        numYearFilm.Value = Decimal.Parse(dgvwFilm.Rows[e.RowIndex].Cells[1].Value.ToString().Remove(0, 6).Substring(0, dgvwFilm.Rows[e.RowIndex].Cells[1].Value.ToString().Remove(0, 6).Length - 8));
                        txtProducer.Text = dgvwFilm.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtGenre.Text = dgvwFilm.Rows[e.RowIndex].Cells[3].Value.ToString();
                        cboFormatFilm.SelectedItem = dgvwFilm.Rows[e.RowIndex].Cells[4].Value.ToString();
                        cboRating.SelectedItem = dgvwFilm.Rows[e.RowIndex].Cells[5].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            try
            {
                txtNameFilmSession.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_session @Время_сеанса, @Название_фильма, @Год_выпуска";
                    cmd.Parameters.Add("@Время_сеанса", SqlDbType.NVarChar).Value = dtmTimeSession.Text;
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilmSession.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearSession.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.сеансTableAdapter.Fill(this.sessionDataSet.Сеанс);
                }

                txtNameFilmSession.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnUpdateSession_Click(object sender, EventArgs e)
        {
            try
            {
                txtNameFilmSession.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Update_session @Время_сеанса, @Название_фильма, @Год_выпуска";
                    cmd.Parameters.Add("@Время_сеанса", SqlDbType.NVarChar).Value = dtmTimeSession.Text;
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilmSession.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearSession.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.сеансTableAdapter.Fill(this.sessionDataSet.Сеанс);
                }

                txtNameFilmSession.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "EXEC Delete_session @Время_сеанса";
                cmd.Parameters.Add("@Время_сеанса", SqlDbType.NVarChar).Value = dtmTimeSession.Text;
                con.InfoMessage += connection_InfoMessage;
                cmd.ExecuteNonQuery();
                con.Close();
                this.сеансTableAdapter.Fill(this.sessionDataSet.Сеанс);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddSessionHall_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumHallSessionHall.CausesValidation = true;
                txtNameFilmSessionHall.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_session_in_Hall @Время_сеанса, @Номер_зала, @Название_фильма, @Год_выпуска";
                    cmd.Parameters.Add("@Время_сеанса", SqlDbType.NVarChar).Value = dtmTimeSessionHall.Text;
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHallSessionHall.Text);
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilmSessionHall.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearSessionHall.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.сеансы_залаTableAdapter.Fill(this.sessionInHallDataSet.Сеансы_зала);
                    this.сеансTableAdapter.Fill(this.sessionDataSet.Сеанс);
                }

                txtNumHallSessionHall.CausesValidation = false;
                txtNameFilmSessionHall.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteSessionHall_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumHallSessionHall.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_session_in_Hall @Время_сеанса, @Номер_зала";
                    cmd.Parameters.Add("@Время_сеанса", SqlDbType.NVarChar).Value = dtmTimeSessionHall.Text;
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHallSessionHall.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.сеансы_залаTableAdapter.Fill(this.sessionInHallDataSet.Сеансы_зала);
                }

                txtNumHallSessionHall.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumHall.CausesValidation = true;
                txtDescriptionHall.CausesValidation = true;
                txtQuantityPlaceHall.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_Hall @Номер_зала, @Описание_зала, @Количество_мест";
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHall.Text);
                    cmd.Parameters.Add("@Описание_зала", SqlDbType.NVarChar).Value = txtDescriptionHall.Text;
                    cmd.Parameters.Add("@Количество_мест", SqlDbType.NVarChar).Value = txtQuantityPlaceHall.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.залTableAdapter.Fill(this.hallDataSet.Зал);
                }

                txtNumHall.CausesValidation = false;
                txtDescriptionHall.CausesValidation = false;
                txtQuantityPlaceHall.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnUpdateHall_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumHall.CausesValidation = true;
                txtDescriptionHall.CausesValidation = true;
                txtQuantityPlaceHall.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Update_Hall @Номер_зала, @Описание_зала, @Количество_мест";
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHall.Text);
                    cmd.Parameters.Add("@Описание_зала", SqlDbType.NVarChar).Value = txtDescriptionHall.Text;
                    cmd.Parameters.Add("@Количество_мест", SqlDbType.NVarChar).Value = txtQuantityPlaceHall.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.залTableAdapter.Fill(this.hallDataSet.Зал);
                }

                txtNumHall.CausesValidation = false;
                txtDescriptionHall.CausesValidation = false;
                txtQuantityPlaceHall.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteHall_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumHall.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_Hall @Номер_зала";
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHall.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.залTableAdapter.Fill(this.hallDataSet.Зал);
                }

                txtNumHall.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddShowFilm_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumHallShowFilm.CausesValidation = true;
                txtNameFilmShowFilm.CausesValidation = true;
                txtProducerShowsFilm.CausesValidation = true;
                txtGenreShowsFilm.CausesValidation = true;
                cboFormatFilmShowsFilm.CausesValidation = true;
                cboRatingFilmShowsFilm.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_shows_the_film @Номер_зала, @Название_фильма, @Год_выпуска, @Режиссёр, @Жанр, @Формат, @Рейтинг";
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHallShowFilm.Text);
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilmShowFilm.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearFilmShowFilm.Text;
                    cmd.Parameters.Add("@Режиссёр", SqlDbType.NVarChar).Value = txtProducerShowsFilm.Text;
                    cmd.Parameters.Add("@Жанр", SqlDbType.NVarChar).Value = txtGenreShowsFilm.Text;
                    cmd.Parameters.Add("@Формат", SqlDbType.NVarChar).Value = cboFormatFilmShowsFilm.SelectedItem.ToString();
                    cmd.Parameters.Add("@Рейтинг", SqlDbType.NVarChar).Value = cboRatingFilmShowsFilm.SelectedItem.ToString();
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.показывает_фильмTableAdapter.Fill(this.showFilmDataSet.Показывает_фильм);
                    this.фильмTableAdapter.Fill(this.filmDataSet.Фильм);
                }

                txtNumHallShowFilm.CausesValidation = false;
                txtNameFilmShowFilm.CausesValidation = false;
                txtProducerShowsFilm.CausesValidation = false;
                txtGenreShowsFilm.CausesValidation = false;
                cboFormatFilmShowsFilm.CausesValidation = false;
                cboRatingFilmShowsFilm.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteShowFilm_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumHallShowFilm.CausesValidation = true;
                txtNameFilmShowFilm.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_shows_the_film @Номер_зала, @Название_фильма, @Год_выпуска";
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHallShowFilm.Text);
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = txtNameFilmShowFilm.Text;
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = numYearFilmShowFilm.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.показывает_фильмTableAdapter.Fill(this.showFilmDataSet.Показывает_фильм);
                }

                txtNumHallShowFilm.CausesValidation = false;
                txtNameFilmShowFilm.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddPlaceHall_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumHallPlaceHall.CausesValidation = true;
                txtNumRowPlaceHall.CausesValidation = true;
                txtNumPlaceHall.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_place_in_Hall @Номер_места, @Номер_ряда, @Номер_зала";
                    cmd.Parameters.Add("@Номер_места", SqlDbType.Int).Value = int.Parse(txtNumPlaceHall.Text);
                    cmd.Parameters.Add("@Номер_ряда", SqlDbType.Int).Value = int.Parse(txtNumRowPlaceHall.Text);
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHallPlaceHall.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.места_в_залеTableAdapter.Fill(this.placeInHallDataSet.Места_в_зале);
                }

                txtNumHallPlaceHall.CausesValidation = false;
                txtNumRowPlaceHall.CausesValidation = false;
                txtNumPlaceHall.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeletePlaceHall_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumHallPlaceHall.CausesValidation = true;
                txtNumRowPlaceHall.CausesValidation = true;
                txtNumPlaceHall.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_place_in_Hall @Номер_места, @Номер_ряда, @Номер_зала";
                    cmd.Parameters.Add("@Номер_места", SqlDbType.Int).Value = int.Parse(txtNumPlaceHall.Text);
                    cmd.Parameters.Add("@Номер_ряда", SqlDbType.Int).Value = int.Parse(txtNumRowPlaceHall.Text);
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHallPlaceHall.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.места_в_залеTableAdapter.Fill(this.placeInHallDataSet.Места_в_зале);
                }

                txtNumHallPlaceHall.CausesValidation = false;
                txtNumRowPlaceHall.CausesValidation = false;
                txtNumPlaceHall.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddGroupPlaceHall_Click(object sender, EventArgs e)
        {
            try
            {
                txtGroupNumHallPlace.CausesValidation = true;
                txtGroupNumRowHallPlace.CausesValidation = true;
                txtGroupQuantityPlaceHall.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_place_in_Row_Hall @Номер_зала, @Номер_ряда, @Количество_мест";
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtGroupNumHallPlace.Text);
                    cmd.Parameters.Add("@Номер_ряда", SqlDbType.Int).Value = int.Parse(txtGroupNumRowHallPlace.Text);
                    cmd.Parameters.Add("@Количество_мест", SqlDbType.Int).Value = int.Parse(txtGroupQuantityPlaceHall.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.места_в_залеTableAdapter.Fill(this.placeInHallDataSet.Места_в_зале);
                }

                txtGroupNumHallPlace.CausesValidation = false;
                txtGroupNumRowHallPlace.CausesValidation = false;
                txtGroupQuantityPlaceHall.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwSession_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwSession.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtNameFilmSession.Text = dgvwSession.Rows[e.RowIndex].Cells[1].Value.ToString();
                        numYearSession.Value = Decimal.Parse(dgvwSession.Rows[e.RowIndex].Cells[2].Value.ToString().Remove(0, 6).Substring(0, dgvwSession.Rows[e.RowIndex].Cells[2].Value.ToString().Remove(0, 6).Length - 8));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwHall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwHall.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtNumHall.Text = dgvwHall.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtDescriptionHall.Text = dgvwHall.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtQuantityPlaceHall.Text = dgvwHall.Rows[e.RowIndex].Cells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwPlaceHall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwPlaceHall.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtNumHallPlaceHall.Text = dgvwPlaceHall.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtNumRowPlaceHall.Text = dgvwPlaceHall.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtNumPlaceHall.Text = dgvwPlaceHall.Rows[e.RowIndex].Cells[0].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwShowFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwShowFilm.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtNumHallShowFilm.Text = dgvwShowFilm.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtNameFilmShowFilm.Text = dgvwShowFilm.Rows[e.RowIndex].Cells[1].Value.ToString();
                        numYearFilmShowFilm.Value = Decimal.Parse(dgvwShowFilm.Rows[e.RowIndex].Cells[2].Value.ToString().Remove(0, 6).Substring(0, dgvwShowFilm.Rows[e.RowIndex].Cells[2].Value.ToString().Remove(0, 6).Length - 8));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddWorkerHall_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtNumHallWorkerHall.CausesValidation = true;
                txtNameWorkerHall.CausesValidation = true;
                txtmPassportWorkerHall.CausesValidation = true;
                txtNamePostWorkerHall.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_worker_in_Hall @Номер_зала, @ФИО_сотрудника, @Паспорт, @Название_должности";
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHallWorkerHall.Text);
                    cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorkerHall.Text;
                    cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassportWorkerHall.Text;
                    cmd.Parameters.Add("@Название_должности", SqlDbType.NVarChar).Value = txtNamePostWorkerHall.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.сотрудники_залаTableAdapter.Fill(this.workerHallDataSet.Сотрудники_зала);
                }

                txtNumHallWorkerHall.CausesValidation = false;
                txtNameWorkerHall.CausesValidation = false;
                txtmPassportWorkerHall.CausesValidation = false;
                txtNamePostWorkerHall.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnUpdateWorkerHall_Click_1(object sender, EventArgs e)
        {
            txtNumHallWorkerHall.CausesValidation = true;
            txtNameWorkerHall.CausesValidation = true;
            txtmPassportWorkerHall.CausesValidation = true;
            txtNamePostWorkerHall.CausesValidation = true;

            if (ValidateChildren())
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "EXEC Update_worker_in_Hall @Номер_зала, @ФИО_сотрудника, @Паспорт, @Название_должности";
                cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHallWorkerHall.Text);
                cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorkerHall.Text;
                cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassportWorkerHall.Text;
                cmd.Parameters.Add("@Название_должности", SqlDbType.NVarChar).Value = txtNamePostWorkerHall.Text;
                con.InfoMessage += connection_InfoMessage;
                cmd.ExecuteNonQuery();
                con.Close();
                this.сотрудники_залаTableAdapter.Fill(this.workerHallDataSet.Сотрудники_зала);
                this.сотрудникTableAdapter.Fill(this.workerDataSet.Сотрудник);
            }

            txtNumHallWorkerHall.CausesValidation = false;
            txtNameWorkerHall.CausesValidation = false;
            txtmPassportWorkerHall.CausesValidation = false;
            txtNamePostWorkerHall.CausesValidation = false;
        }

        private void btnDeleteWorkerHall_Click_1(object sender, EventArgs e)
        {
            txtNumHallWorkerHall.CausesValidation = true;
            txtNameWorkerHall.CausesValidation = true;
            txtmPassportWorkerHall.CausesValidation = true;

            if (ValidateChildren())
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "EXEC Delete_worker_in_Hall @Номер_зала, @ФИО_сотрудника, @Паспорт";
                cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(txtNumHallWorkerHall.Text);
                cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorkerHall.Text;
                cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassportWorkerHall.Text;
                con.InfoMessage += connection_InfoMessage;
                cmd.ExecuteNonQuery();
                con.Close();
                this.сотрудники_залаTableAdapter.Fill(this.workerHallDataSet.Сотрудники_зала);
            }

            txtNumHallWorkerHall.CausesValidation = false;
            txtNameWorkerHall.CausesValidation = false;
            txtmPassportWorkerHall.CausesValidation = false;
        }

        private void dgvwWorkerHall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwWorkerHall.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtNumHallWorkerHall.Text = dgvwWorkerHall.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtNameWorkerHall.Text = dgvwWorkerHall.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtmPassportWorkerHall.Text = dgvwWorkerHall.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtNamePostWorkerHall.Text = dgvwWorkerHall.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnAddWorker_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtNameWorker.CausesValidation = true;
                txtmPassport.CausesValidation = true;
                txtTitlePostWorker.CausesValidation = true;
                txtmPhoneWorker.CausesValidation = true;
                txtAddress.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_Worker @ФИО_сотрудника, @Паспорт, @Должность, @Номер_телефона, @Адрес";
                    cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorker.Text;
                    cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassport.Text;
                    cmd.Parameters.Add("@Должность", SqlDbType.NVarChar).Value = txtTitlePostWorker.Text;
                    cmd.Parameters.Add("@Номер_телефона", SqlDbType.NVarChar).Value = txtmPhoneWorker.Text;
                    cmd.Parameters.Add("@Адрес", SqlDbType.NVarChar).Value = txtAddress.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.сотрудникTableAdapter.Fill(this.workerDataSet.Сотрудник);
                }

                txtNameWorker.CausesValidation = false;
                txtmPassport.CausesValidation = false;
                txtTitlePostWorker.CausesValidation = false;
                txtmPhoneWorker.CausesValidation = false;
                txtAddress.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnUpdateWorker_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtNameWorker.CausesValidation = true;
                txtmPassport.CausesValidation = true;
                txtTitlePostWorker.CausesValidation = true;
                txtmPhoneWorker.CausesValidation = true;
                txtAddress.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Update_Worker @ФИО_сотрудника, @Паспорт, @Должность, @Номер_телефона, @Адрес";
                    cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorker.Text;
                    cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassport.Text;
                    cmd.Parameters.Add("@Должность", SqlDbType.NVarChar).Value = txtTitlePostWorker.Text;
                    cmd.Parameters.Add("@Номер_телефона", SqlDbType.NVarChar).Value = txtmPhoneWorker.Text;
                    cmd.Parameters.Add("@Адрес", SqlDbType.NVarChar).Value = txtAddress.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.сотрудникTableAdapter.Fill(this.workerDataSet.Сотрудник);
                }

                txtNameWorker.CausesValidation = false;
                txtmPassport.CausesValidation = false;
                txtTitlePostWorker.CausesValidation = false;
                txtmPhoneWorker.CausesValidation = false;
                txtAddress.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnDeleteWorker_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtNameWorker.CausesValidation = true;
                txtmPassport.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_Worker @ФИО_сотрудника, @Паспорт";
                    cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorker.Text;
                    cmd.Parameters.Add("@Паспорт", SqlDbType.NVarChar).Value = txtmPassport.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.сотрудникTableAdapter.Fill(this.workerDataSet.Сотрудник);
                    this.сотрудники_залаTableAdapter.Fill(this.workerHallDataSet.Сотрудники_зала);
                }

                txtNameWorker.CausesValidation = false;
                txtmPassport.CausesValidation = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwWorker_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dgvwWorker.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        txtNameWorker.Text = dgvwWorker.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtmPassport.Text = dgvwWorker.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtTitlePostWorker.Text = dgvwWorker.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtmPhoneWorker.Text = dgvwWorker.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtAddress.Text = dgvwWorker.Rows[e.RowIndex].Cells[4].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvwTicket.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtNumTicket.Text = dgvwTicket.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtmCostTicket.Text = dgvwTicket.Rows[e.RowIndex].Cells[1].Value.ToString();
                    lblNumberTicketDelete.Text = dgvwTicket.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void btnShowFilmTicket_Click(object sender, EventArgs e)
        {
            try
            {
                cboNameFilmTicket.Items.Clear();
                cboDateSessionTicket.Items.Clear();
                cboNumHallTicket.Items.Clear();
                cboNumHallTicket.Items.Clear();
                cboDateSessionTicket.Text = String.Empty;
                cboNumHallTicket.Text = String.Empty;
                dgvwHallTicket.Columns.Clear();
                cboYearFilmTicket.Items.Clear();
                cboYearFilmTicket.Text = String.Empty;
                cboNameFilmTicket.Enabled = true;
                cboYearFilmTicket.Enabled = false;
                cboDateSessionTicket.Enabled = false;
                cboNumHallTicket.Enabled = false;

                SqlCommand command = new SqlCommand("SELECT Название_фильма FROM Свободные_места GROUP BY Название_фильма", con);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cboNameFilmTicket.Items.Add(reader[0].ToString());
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void cboNameFilmTicket_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cboDateSessionTicket.Items.Clear();
                cboDateSessionTicket.Text = String.Empty;
                cboNumHallTicket.Items.Clear();
                cboNumHallTicket.Text = String.Empty;
                dgvwHallTicket.Columns.Clear();
                cboYearFilmTicket.Items.Clear();
                cboYearFilmTicket.Text = String.Empty;
                cboYearFilmTicket.Enabled = true;

                SqlCommand command = new SqlCommand($"SELECT Время_сеанса " +
                                                    $"FROM Свободные_места " +
                                                    $"WHERE Название_фильма = '{cboNameFilmTicket.SelectedItem.ToString()}' " +
                                                    $"GROUP BY Время_сеанса", con);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cboDateSessionTicket.Items.Add(reader[0].ToString().Remove(reader[0].ToString().Length - 3, 3));
                }

                reader.Close();

                SqlCommand command2 = new SqlCommand($"SELECT Год_выпуска " +
                                                     $"FROM Свободные_места " +
                                                     $"WHERE Название_фильма = '{cboNameFilmTicket.SelectedItem.ToString()}' " +
                                                     $"GROUP BY Год_выпуска", con);

                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    string response = reader2[0].ToString();
                    cboYearFilmTicket.Items.Add(response.Substring(0, response.Length - 8).Remove(0, 6));
                }

                reader2.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void cboDateSessionTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboNumHallTicket.Items.Clear();
                cboNumHallTicket.Text = String.Empty;
                dgvwHallTicket.Columns.Clear();
                cboNumHallTicket.Enabled = true;

                SqlCommand command = new SqlCommand($"SELECT Номер_зала " +
                                                    $"FROM Свободные_места " +
                                                    $"WHERE Название_фильма = '{cboNameFilmTicket.SelectedItem.ToString()}' AND " +
                                                    $"Время_сеанса = '{cboDateSessionTicket.SelectedItem.ToString()}' AND Год_выпуска = " +
                                                    $"'{cboYearFilmTicket.SelectedItem.ToString()}' " +
                                                    $"GROUP BY Номер_зала", con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cboNumHallTicket.Items.Add(reader[0].ToString());
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void cboNumHallTicket_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PlaceHall();
        }

        private void PlaceHall()
        {
            try
            {
                List<int> ListOfCol = new List<int>();

                dgvwHallTicket.Columns.Clear();

                SqlCommand command = new SqlCommand($"SELECT * " +
                                                    $"FROM  Места_в_зале " +
                                                    $"WHERE Номер_зала = '{cboNumHallTicket.SelectedItem.ToString()}' " +
                                                    $"GROUP BY Номер_зала, Номер_ряда, Номер_места", con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListOfCol.Add(int.Parse(reader[1].ToString()));
                }

                reader.Close();

                ListOfCol = ListOfCol.Distinct().ToList();
                ListOfCol.Sort();

                foreach (int col in ListOfCol)
                {
                    dgvwHallTicket.Columns.Add("Column" + dgvwHallTicket.Columns.Count, col.ToString());
                }

                int ind = 0;

                foreach (int col in ListOfCol)
                {
                    SqlCommand command2 = new SqlCommand($"SELECT Номер_места " +
                                                         $"FROM Места_в_зале " +
                                                         $"WHERE Номер_зала = '{cboNumHallTicket.SelectedItem.ToString()}' " +
                                                         $"AND Номер_ряда = '{col.ToString()}' " +
                                                         $"GROUP BY Номер_места", con);

                    SqlDataReader reader2 = command2.ExecuteReader();

                    int indR = 0;

                    while (reader2.Read())
                    {
                        dgvwHallTicket.Rows.Add();
                        dgvwHallTicket.Rows[indR].Cells[ind].Value = reader2[0].ToString();
                        dgvwHallTicket.Rows[indR].Cells[ind].Style.BackColor = System.Drawing.Color.Red;
                        indR++;
                    }

                    reader2.Close();

                    ind++;
                }

                ind = 0;

                foreach (int col in ListOfCol)
                {
                    SqlCommand command3 = new SqlCommand($"SELECT Номер_места " +
                                                         $"FROM Свободные_места " +
                                                         $"WHERE Номер_зала = '{cboNumHallTicket.SelectedItem.ToString()}' " +
                                                         $"AND Номер_ряда = '{col.ToString()}' AND Название_фильма = " +
                                                         $"'{cboNameFilmTicket.SelectedItem.ToString()}' AND Год_выпуска = " +
                                                         $"'{cboYearFilmTicket.SelectedItem.ToString()}' AND Время_сеанса = " +
                                                         $"'{cboDateSessionTicket.SelectedItem.ToString()}' " +
                                                         $"GROUP BY Номер_места", con);

                    SqlDataReader reader3 = command3.ExecuteReader();

                    while (reader3.Read())
                    {
                        for (int indR = 0; indR < dgvwHallTicket.Rows.Count; indR++)
                        {
                            if (dgvwHallTicket.Rows[indR].Cells[ind].Value != null)
                            {
                                if (reader3[0].ToString() == dgvwHallTicket.Rows[indR].Cells[ind].Value.ToString())
                                {
                                    dgvwHallTicket.Rows[indR].Cells[ind].Style.BackColor = System.Drawing.Color.Aqua;
                                }
                            }
                            else
                            {
                                int count = 0;

                                for (int i = 0; i < dgvwHallTicket.Columns.Count; i++)
                                {
                                    if (dgvwHallTicket.Rows[indR].Cells[i].Value == null)
                                    {
                                        count++;
                                    }
                                }

                                if (count == dgvwHallTicket.Columns.Count)
                                {
                                    dgvwHallTicket.Rows.RemoveAt(indR);
                                }
                            }
                        }
                    }

                    ind++;

                    reader3.Close();
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void dgvwHallTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dgvwHallTicket.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == System.Drawing.Color.Red)
                {
                    MessageBox.Show("Место занято!");
                }
                else
                {
                    if (dgvwHallTicket.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        grpSellTicketPlace.Enabled = true;
                        lblNumPlaceTicket.Text = dgvwHallTicket.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        lblNumRowTicket.Text = dgvwHallTicket.Columns[e.ColumnIndex].HeaderText;
                    }
                }
            }
        }

        private void btnAddTicket_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtNumTicket.CausesValidation = true;
                txtmCostTicket.CausesValidation = true;
                txtNameWorkerTicket.CausesValidation = true;
                txtNameClientTicket.CausesValidation = true;
                txtmPassportWorkerTicket.CausesValidation = true;
                txtmPhoneClientTicket.CausesValidation = true;

                if (ValidateChildren())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    SqlCommand command = new SqlCommand($"SELECT Скидка " +
                                                        $"FROM Клиент " +
                                                        $"WHERE ФИО_клиента = '{txtNameClientTicket.Text}' " +
                                                        $"AND Телефон_клиента = '{txtmPhoneClientTicket.Text}'", con);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        txtmCostTicket.Text = (int.Parse(txtmCostTicket.Text) - int.Parse(txtmCostTicket.Text) * int.Parse(reader[0].ToString()) / 100).ToString();
                    }

                    reader.Close();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_ticket @Номер_билета, @Цена_билета, @Дата_и_время_продажи_билета";
                    cmd.Parameters.Add("@Номер_билета", SqlDbType.Int).Value = int.Parse(txtNumTicket.Text);
                    cmd.Parameters.Add("@Цена_билета", SqlDbType.Money).Value = Decimal.Parse(txtmCostTicket.Text);
                    cmd.Parameters.Add("@Дата_и_время_продажи_билета", SqlDbType.NVarChar).Value = DateTime.Now.ToString();
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();

                    cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Insert_ticket_selling @Название_фильма, @Год_выпуска, @Номер_места, @Номер_ряда, @Номер_зала, @ФИО_клиента," +
                        "@Время_сеанса, @ФИО_сотрудника, @Паспорт_сотрудника, @Номер_билета, @Телефон";
                    cmd.Parameters.Add("@Название_фильма", SqlDbType.NVarChar).Value = cboNameFilmTicket.SelectedItem.ToString();
                    cmd.Parameters.Add("@Год_выпуска", SqlDbType.NVarChar).Value = cboYearFilmTicket.SelectedItem.ToString();
                    cmd.Parameters.Add("@Номер_места", SqlDbType.Int).Value = int.Parse(lblNumPlaceTicket.Text);
                    cmd.Parameters.Add("@Номер_ряда", SqlDbType.Int).Value = int.Parse(lblNumRowTicket.Text);
                    cmd.Parameters.Add("@Номер_зала", SqlDbType.Int).Value = int.Parse(cboNumHallTicket.SelectedItem.ToString());
                    cmd.Parameters.Add("@ФИО_клиента", SqlDbType.NVarChar).Value = txtNameClientTicket.Text;
                    cmd.Parameters.Add("@Время_сеанса", SqlDbType.NVarChar).Value = cboDateSessionTicket.SelectedItem.ToString();
                    cmd.Parameters.Add("@ФИО_сотрудника", SqlDbType.NVarChar).Value = txtNameWorkerTicket.Text;
                    cmd.Parameters.Add("@Паспорт_сотрудника", SqlDbType.NVarChar).Value = txtmPassportWorkerTicket.Text;
                    cmd.Parameters.Add("@Номер_билета", SqlDbType.Int).Value = int.Parse(txtNumTicket.Text);
                    cmd.Parameters.Add("@Телефон", SqlDbType.NVarChar).Value = txtmPhoneClientTicket.Text;
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();

                    Brush Brush = new SolidBrush(Color.Black);
                    Pen Pen = new Pen(Color.Black, 2);

                    picTicket.Image = Properties.Resources.ticket;

                    Bitmap map = (Bitmap)picTicket.Image;

                    SqlCommand command2 = new SqlCommand($"SELECT Формат, Рейтинг " +
                                                         $"FROM Фильм " +
                                                         $"WHERE Название_фильма = '{cboNameFilmTicket.SelectedItem.ToString()}' " +
                                                         $"AND Год_выпуска = '{cboYearFilmTicket.SelectedItem.ToString()}'", con);

                    SqlDataReader reader2 = command2.ExecuteReader();

                    string format = String.Empty;
                    string rating = String.Empty;

                    while (reader2.Read())
                    {
                        format = reader2[0].ToString();
                        rating = reader2[1].ToString();
                    }

                    reader2.Close();

                    Graphics G = Graphics.FromImage(map);
                    G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    G.DrawString("Билет " + txtNumTicket.Text, Font, Brush, 120, 5);
                    G.DrawString(rating, Font, Brush, 245, 5);
                    G.DrawString(cboNameFilmTicket.SelectedItem.ToString() + " " + format, Font, Brush, 5, 20);
                    G.DrawString("Время: " + cboDateSessionTicket.SelectedItem.ToString(), Font, Brush, 5, 35);
                    G.DrawString("Зал: " + cboNumHallTicket.SelectedItem.ToString(), Font, Brush, 5, 50);
                    G.DrawString("Место: " + lblNumPlaceTicket.Text, Font, Brush, 48, 50);
                    G.DrawString("Ряд: " + lblNumRowTicket.Text, Font, Brush, 107, 50);
                    G.DrawString("Цена: " + txtmCostTicket.Text, Font, Brush, 5, 65);
                    G.DrawString("Кассир: " + txtNameWorkerTicket.Text, Font, Brush, 5, 80);
                    G.DrawString("Продан: " + DateTime.Now.ToString(), Font, Brush, 5, 95);
                    G.DrawLine(Pen, 0, 110, picTicket.Width, 110);
                    G.DrawString("КОНТРОЛЬ", Font, Brush, 110, 120);

                    picTicket.Image = map;

                    G.Dispose();
                    Pen.Dispose();
                    Brush.Dispose();
                }

                txtNumTicket.CausesValidation = false;
                txtmCostTicket.CausesValidation = false;
                txtNameWorkerTicket.CausesValidation = false;
                txtNameClientTicket.CausesValidation = false;
                txtmPassportWorkerTicket.CausesValidation = false;
                txtmPhoneClientTicket.CausesValidation = false;

                con.Close();
                this.билетTableAdapter.Fill(this.ticketDataSet.Билет);
                this.продажа_билетовTableAdapter.Fill(this.soldTicketsDataSet.Продажа_билетов);
                this.топ_кассировTableAdapter.Fill(this.topCashierDataSet.Топ_кассиров);
                this.топ_клиентовTableAdapter.Fill(this.topClientDataSet.Топ_клиентов);
                this.топ_фильмовTableAdapter.Fill(this.topFilmDataSet.Топ_фильмов);
                this.кол_билетов_залаTableAdapter.Fill(this.countOfTicketDataSet.Кол_билетов_зала);
                PlaceHall();

                btnPrint.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void txtNumTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void txtmCostTicket_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument printDoc = new PrintDocument();
                PrintDialog dlg = new PrintDialog();
                dlg.Document = printDoc;
                if (dlg.ShowDialog() != DialogResult.Cancel)
                {
                    printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(picTicket.Image, -1, -1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void cboYearFilmTicket_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboDateSessionTicket.Enabled = true;
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtNumTicket.Text))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "EXEC Delete_ticket @Номер_билета";
                    cmd.Parameters.Add("@Номер_билета", SqlDbType.Int).Value = int.Parse(lblNumberTicketDelete.Text);
                    con.InfoMessage += connection_InfoMessage;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.билетTableAdapter.Fill(this.ticketDataSet.Билет);
                }
                else
                {
                    MessageBox.Show("Заполните необходимые поля!", "Ошибка удаления");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        private void txtNameFilm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameFilm.Text))
            {
                errorProvider.SetError(txtNameFilm, "Название фильма пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameFilm, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtProducer_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtProducer.Text))
            {
                errorProvider.SetError(txtProducer, "ФИО режиссёра пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtProducer, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtGenre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtGenre.Text))
            {
                errorProvider.SetError(txtGenre, "Название жанра пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtGenre, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameFilmSession_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameFilmSession.Text))
            {
                errorProvider.SetError(txtNameFilmSession, "Название фильма пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameFilmSession, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNumHallSessionHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumHallSessionHall.Text))
            {
                errorProvider.SetError(txtNumHallSessionHall, "Номер зала пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumHallSessionHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameFilmSessionHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameFilmSessionHall.Text))
            {
                errorProvider.SetError(txtNameFilmSessionHall, "Название фильма пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameFilmSessionHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNumHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumHall.Text))
            {
                errorProvider.SetError(txtNumHall, "Номер зала пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescriptionHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescriptionHall.Text))
            {
                errorProvider.SetError(txtDescriptionHall, "Описание зала пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDescriptionHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtQuantityPlaceHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtQuantityPlaceHall.Text))
            {
                errorProvider.SetError(txtQuantityPlaceHall, "Количество мест пустое или содержит пробелы! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtQuantityPlaceHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNumHallShowFilm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumHallShowFilm.Text))
            {
                errorProvider.SetError(txtNumHallShowFilm, "Номер зала пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumHallShowFilm, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameFilmShowFilm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameFilmShowFilm.Text))
            {
                errorProvider.SetError(txtNameFilmShowFilm, "Название фильма пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameFilmShowFilm, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtProducerShowsFilm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtProducerShowsFilm.Text))
            {
                errorProvider.SetError(txtProducerShowsFilm, "ФИО режиссёра пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtProducerShowsFilm, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtGenreShowsFilm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtGenreShowsFilm.Text))
            {
                errorProvider.SetError(txtGenreShowsFilm, "Название жанра пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtGenreShowsFilm, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNumHallPlaceHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumHallPlaceHall.Text))
            {
                errorProvider.SetError(txtNumHallPlaceHall, "Номер зала пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumHallPlaceHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNumRowPlaceHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumRowPlaceHall.Text))
            {
                errorProvider.SetError(txtNumRowPlaceHall, "Номер ряда пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumRowPlaceHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNumPlaceHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumPlaceHall.Text))
            {
                errorProvider.SetError(txtNumPlaceHall, "Номер места пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumPlaceHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtGroupNumHallPlace_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtGroupNumHallPlace.Text))
            {
                errorProvider.SetError(txtGroupNumHallPlace, "Номер зала пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtGroupNumHallPlace, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtGroupNumRowHallPlace_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtGroupNumRowHallPlace.Text))
            {
                errorProvider.SetError(txtGroupNumRowHallPlace, "Номер ряда пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtGroupNumRowHallPlace, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtGroupQuantityPlaceHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtGroupQuantityPlaceHall.Text))
            {
                errorProvider.SetError(txtGroupQuantityPlaceHall, "Номер места пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtGroupQuantityPlaceHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPhone_MouseClick(object sender, MouseEventArgs e)
        {
            string text = txtmPhoneClientTicket.Text;
            text = text.Replace('_', ' ').TrimEnd();

            if (!txtmPhone.MaskCompleted)
            {
                ((MaskedTextBox)sender).SelectionStart = text.Length;
                ((MaskedTextBox)sender).Select();
            }
        }

        private void txtFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "ФИО клиента пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFullName, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtDiscountCard_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDiscountCard.Text))
            {
                errorProvider.SetError(txtDiscountCard, "Дисконтная карта пустая!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDiscountCard, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!reg.IsMatch(txtEmail.Text) || String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Email пустой или имеет неверный формат!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtmPhone.MaskCompleted == false)
            {
                errorProvider.SetError(txtmPhone, "Телефон имеет неверный формат!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtmPhone, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNumTicket_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumTicket.Text))
            {
                errorProvider.SetError(txtNumTicket, "Номер билета пустой или содержит пробелы! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumTicket, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmCostTicket_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtmCostTicket.Text))
            {
                errorProvider.SetError(txtmCostTicket, "Цена билета пустая или содержит пробелы! Вводить можно только цифры и запятую!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtmCostTicket, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameClientTicket_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameClientTicket.Text))
            {
                errorProvider.SetError(txtNameClientTicket, "ФИО клиента пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameClientTicket, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameWorkerTicket_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameWorkerTicket.Text))
            {
                errorProvider.SetError(txtNameWorkerTicket, "ФИО сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameWorkerTicket, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassportWorkerTicket_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!txtmPassportWorkerTicket.MaskCompleted)
            {
                errorProvider.SetError(txtmPassportWorkerTicket, "Паспортные данные сотрудника пустые или имеют неверный формат!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtmPassportWorkerTicket, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPhoneClientTicket_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!txtmPhoneClientTicket.MaskCompleted)
            {
                errorProvider.SetError(txtmPhoneClientTicket, "Номер телефона клиента имеет неверный формат!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtmPhoneClientTicket, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPhoneClientTicket_MouseClick(object sender, MouseEventArgs e)
        {
            string text = txtmPhoneClientTicket.Text;
            text = text.Replace('_', ' ').TrimEnd();

            if (!txtmPhoneClientTicket.MaskCompleted)
            {
                ((MaskedTextBox)sender).SelectionStart = text.Length;
                ((MaskedTextBox)sender).Select();
            }
        }

        private void txtmPhoneClientTicket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void txtmPassportWorkerTicket_MouseClick(object sender, MouseEventArgs e)
        {
            string text = txtmPhoneClientTicket.Text;
            text = text.Replace('_', ' ').TrimEnd();

            if (!txtmPassportWorkerTicket.MaskCompleted)
            {
                ((MaskedTextBox)sender).SelectionStart = text.Length - 2;
                ((MaskedTextBox)sender).Select();
            }
        }

        private void txtmPassportWorkerTicket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void txtmPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void txtNumAcquisitionLicense_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumAcquisitionLicense.Text))
            {
                errorProvider.SetError(txtNumAcquisitionLicense, "Номер лицензии пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumAcquisitionLicense, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameFilmAcquisitionLicense_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameFilmAcquisitionLicense.Text))
            {
                errorProvider.SetError(txtNameFilmAcquisitionLicense, "Название фильма пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameFilmAcquisitionLicense, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameWorkerAcquisitionLicense_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameWorkerAcquisitionLicense.Text))
            {
                errorProvider.SetError(txtNameWorkerAcquisitionLicense, "ФИО сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameWorkerAcquisitionLicense, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtTitlePostAcquisitionLicense_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTitlePostAcquisitionLicense.Text))
            {
                errorProvider.SetError(txtTitlePostAcquisitionLicense, "Название должности пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTitlePostAcquisitionLicense, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassportWorkerAcquisitionLicense_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!txtmPassportWorkerAcquisitionLicense.MaskCompleted)
            {
                errorProvider.SetError(txtmPassportWorkerAcquisitionLicense, "Номер паспорта пустой или имеет неверный формат!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtmPassportWorkerAcquisitionLicense, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassportWorkerAcquisitionLicense_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void txtmPassportWorkerAcquisitionLicense_MouseClick(object sender, MouseEventArgs e)
        {
            string text = txtmPassportWorkerAcquisitionLicense.Text;
            text = text.Replace('_', ' ').TrimEnd();

            if (!txtmPassportWorkerAcquisitionLicense.MaskCompleted)
            {
                ((MaskedTextBox)sender).SelectionStart = text.Length;
                ((MaskedTextBox)sender).Select();
            }
        }

        private void txtNumLicense_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumLicense.Text))
            {
                errorProvider.SetError(txtNumLicense, "Номер лицензии пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumLicense, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtCostLicense_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCostLicense.Text))
            {
                errorProvider.SetError(txtCostLicense, "Цена лицензии пустая! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCostLicense, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescriptionLicense_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescriptionLicense.Text))
            {
                errorProvider.SetError(txtDescriptionLicense, "Описание лицензии пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDescriptionLicense, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtEquipmentID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEquipmentID.Text))
            {
                errorProvider.SetError(txtEquipmentID, "ID оборудования пустое! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEquipmentID, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescriptionEquipment_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescriptionEquipment.Text))
            {
                errorProvider.SetError(txtDescriptionEquipment, "Описание оборудования пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDescriptionEquipment, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtEquipmentIDFilm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEquipmentIDFilm.Text))
            {
                errorProvider.SetError(txtEquipmentIDFilm, "ID оборудования пустое! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEquipmentIDFilm, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameFilmShowing_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameFilmShowing.Text))
            {
                errorProvider.SetError(txtNameFilmShowing, "Название фильма пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameFilmShowing, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameWorkerShowing_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameWorkerShowing.Text))
            {
                errorProvider.SetError(txtNameWorkerShowing, "ФИО сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameWorkerShowing, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassportShowing_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!txtmPassportShowing.MaskCompleted)
            {
                errorProvider.SetError(txtmPassportShowing, "Номер паспорта пустой или имеет неверный формат!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtmPassportShowing, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtTitlePostShowing_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTitlePostShowing.Text))
            {
                errorProvider.SetError(txtTitlePostShowing, "Название должности сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTitlePostShowing, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassportShowing_MouseClick(object sender, MouseEventArgs e)
        {
            string text = txtmPassportShowing.Text;
            text = text.Replace('_', ' ').TrimEnd();

            if (!txtmPassportShowing.MaskCompleted)
            {
                ((MaskedTextBox)sender).SelectionStart = text.Length;
                ((MaskedTextBox)sender).Select();
            }
        }

        private void txtmPassportShowing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void txtTitlePost_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTitlePost.Text))
            {
                errorProvider.SetError(txtTitlePost, "Название должности сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTitlePost, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescriptionPost_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescriptionPost.Text))
            {
                errorProvider.SetError(txtDescriptionPost, "Описание должности сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDescriptionPost, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtSalary_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSalary.Text))
            {
                errorProvider.SetError(txtSalary, "Зарплата сотрудника пустая! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSalary, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameWorker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameWorker.Text))
            {
                errorProvider.SetError(txtNameWorker, "ФИО сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameWorker, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassport_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!txtmPassport.MaskCompleted)
            {
                errorProvider.SetError(txtmPassport, "Номер паспорта пустой или имеет неверный формат!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtmPassport, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtTitlePostWorker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTitlePostWorker.Text))
            {
                errorProvider.SetError(txtTitlePostWorker, "Название должности сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTitlePostWorker, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPhoneWorker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!txtmPhoneWorker.MaskCompleted)
            {
                errorProvider.SetError(txtmPhoneWorker, "Номер телефона имеет неверный формат!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtmPhoneWorker, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Адрес сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAddress, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassport_MouseClick(object sender, MouseEventArgs e)
        {
            string text = txtmPassport.Text;
            text = text.Replace('_', ' ').TrimEnd();

            if (!txtmPassport.MaskCompleted)
            {
                ((MaskedTextBox)sender).SelectionStart = text.Length;
                ((MaskedTextBox)sender).Select();
            }
        }

        private void txtmPassport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void txtmPhoneWorker_MouseClick(object sender, MouseEventArgs e)
        {
            string text = txtmPhoneWorker.Text;
            text = text.Replace('_', ' ').TrimEnd();

            if (!txtmPhoneWorker.MaskCompleted)
            {
                ((MaskedTextBox)sender).SelectionStart = text.Length;
                ((MaskedTextBox)sender).Select();
            }
        }

        private void txtmPhoneWorker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void txtNumHallWorkerHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumHallWorkerHall.Text))
            {
                errorProvider.SetError(txtNumHallWorkerHall, "Номер зала пустой! Вводить можно только цифры!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNumHallWorkerHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameWorkerHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNameWorkerHall.Text))
            {
                errorProvider.SetError(txtNameWorkerHall, "ФИО сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNameWorkerHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassportWorkerHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!txtmPassportWorkerHall.MaskCompleted)
            {
                errorProvider.SetError(txtmPassportWorkerHall, "Номер паспорта пустой или имеет неверный формат!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtmPassportWorkerHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtNamePostWorkerHall_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNamePostWorkerHall.Text))
            {
                errorProvider.SetError(txtNamePostWorkerHall, "Название должности сотрудника пустое или содержит пробелы!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNamePostWorkerHall, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtmPassportWorkerHall_MouseClick(object sender, MouseEventArgs e)
        {
            string text = txtmPassportWorkerHall.Text;
            text = text.Replace('_', ' ').TrimEnd();

            if (!txtmPassportWorkerHall.MaskCompleted)
            {
                ((MaskedTextBox)sender).SelectionStart = text.Length;
                ((MaskedTextBox)sender).Select();
            }
        }

        private void txtmPassportWorkerHall_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }
        }

        private void cboFormatFilm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cboFormatFilm.SelectedIndex == -1)
            {
                errorProvider.SetError(cboFormatFilm, "Формат фильма не выбран!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cboFormatFilm, String.Empty);
                e.Cancel = false;
            }
        }

        private void cboRating_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cboRating.SelectedIndex == -1)
            {
                errorProvider.SetError(cboRating, "Рейтинг фильма не выбран!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cboRating, String.Empty);
                e.Cancel = false;
            }
        }

        private void cboFormatFilmShowsFilm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cboFormatFilmShowsFilm.SelectedIndex == -1)
            {
                errorProvider.SetError(cboFormatFilmShowsFilm, "Формат фильма не выбран!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cboFormatFilmShowsFilm, String.Empty);
                e.Cancel = false;
            }
        }

        private void cboRatingFilmShowsFilm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cboRatingFilmShowsFilm.SelectedIndex == -1)
            {
                errorProvider.SetError(cboRatingFilmShowsFilm, "Рейтинг фильма не выбран!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cboRatingFilmShowsFilm, String.Empty);
                e.Cancel = false;
            }
        }

        private void cboTypeClient_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cboTypeClient.SelectedIndex == -1)
            {
                errorProvider.SetError(cboTypeClient, "Тип клиента не выбран!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cboTypeClient, String.Empty);
                e.Cancel = false;
            }
        }

        private void cboEquipmentFormat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cboEquipmentFormat.SelectedIndex == -1)
            {
                errorProvider.SetError(cboEquipmentFormat, "Формат оборудования не выбран!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cboEquipmentFormat, String.Empty);
                e.Cancel = false;
            }
        }

        private void dtmTimeSession_Enter(object sender, EventArgs e)
        {
            dtmTimeSession.MaxDate = DateTime.Parse($"{(DateTime.Now.Day + 7).ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()}");
            dtmTimeSession.MinDate = DateTime.Parse($"{DateTime.Now.Day.ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()} {DateTime.Now.Hour}:{DateTime.Now.Minute}");
        }

        private void dtmTimeSessionHall_Enter(object sender, EventArgs e)
        {
            dtmTimeSessionHall.MaxDate = DateTime.Parse($"{(DateTime.Now.Day + 7).ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()}");
            dtmTimeSessionHall.MinDate = DateTime.Parse($"{DateTime.Now.Day.ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()} {DateTime.Now.Hour}:{DateTime.Now.Minute}");
        }     
            
        private void dtmLicenseValidityPeriod_Enter(object sender, EventArgs e)
        {
            dtmLicenseValidityPeriod.MaxDate = DateTime.Parse($"31.12.2099");
            dtmLicenseValidityPeriod.MinDate = DateTime.Parse($"{DateTime.Now.Day.ToString()}.{DateTime.Now.Month.ToString()}.{DateTime.Now.Year.ToString()}");
        }
    }
}
