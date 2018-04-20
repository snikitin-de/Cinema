namespace Cinema
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource85 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource86 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource87 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource88 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource89 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource90 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Топ_фильмовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topFilmDataSet = new Cinema.TopFilmDataSet();
            this.Залы_без_фильмовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallWithoutFilmDataSet = new Cinema.HallWithoutFilmDataSet();
            this.Кол_билетов_залаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countOfTicketDataSet = new Cinema.CountOfTicketDataSet();
            this.Топ_клиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topClientDataSet = new Cinema.TopClientDataSet();
            this.Продажа_билетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soldTicketsDataSet = new Cinema.SoldTicketsDataSet();
            this.Топ_кассировBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topCashierDataSet = new Cinema.TopCashierDataSet();
            this.tabWorker = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabFilm = new System.Windows.Forms.TabPage();
            this.numYearFilm = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateFilm = new System.Windows.Forms.Button();
            this.btnDeleteFilm = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.dgvwFilm = new System.Windows.Forms.DataGridView();
            this.названиефильмаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годвыпускаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.режиссёрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.форматDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтингDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фильмBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmDataSet = new Cinema.FilmDataSet();
            this.cboRating = new System.Windows.Forms.ComboBox();
            this.cboFormatFilm = new System.Windows.Forms.ComboBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.txtNameFilm = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblFormatFilm = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblNameFilm = new System.Windows.Forms.Label();
            this.lblYearFilm = new System.Windows.Forms.Label();
            this.tabSession = new System.Windows.Forms.TabPage();
            this.grpSession = new System.Windows.Forms.GroupBox();
            this.numYearSession = new System.Windows.Forms.NumericUpDown();
            this.dtmTimeSession = new System.Windows.Forms.DateTimePicker();
            this.dgvwSession = new System.Windows.Forms.DataGridView();
            this.времясеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефильмаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годвыпускаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сеансBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionDataSet = new Cinema.SessionDataSet();
            this.lblTimeSession = new System.Windows.Forms.Label();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.btnUpdateSession = new System.Windows.Forms.Button();
            this.lblNameFilmSession = new System.Windows.Forms.Label();
            this.txtNameFilmSession = new System.Windows.Forms.TextBox();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.lblYearFilmSession = new System.Windows.Forms.Label();
            this.grpSessionHall = new System.Windows.Forms.GroupBox();
            this.numYearSessionHall = new System.Windows.Forms.NumericUpDown();
            this.lblNameFilmSessionHall = new System.Windows.Forms.Label();
            this.txtNameFilmSessionHall = new System.Windows.Forms.TextBox();
            this.lblYearFilmSessionHall = new System.Windows.Forms.Label();
            this.dtmTimeSessionHall = new System.Windows.Forms.DateTimePicker();
            this.dgvwSessionHall = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сеансызалаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionInHallDataSet = new Cinema.SessionInHallDataSet();
            this.txtNumHallSessionHall = new System.Windows.Forms.TextBox();
            this.lblTimeSessionHall = new System.Windows.Forms.Label();
            this.btnDeleteSessionHall = new System.Windows.Forms.Button();
            this.lblNumHallSessionHall = new System.Windows.Forms.Label();
            this.btnAddSessionHall = new System.Windows.Forms.Button();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.grpShowFilm = new System.Windows.Forms.GroupBox();
            this.numYearFilmShowFilm = new System.Windows.Forms.NumericUpDown();
            this.cboRatingFilmShowsFilm = new System.Windows.Forms.ComboBox();
            this.cboFormatFilmShowsFilm = new System.Windows.Forms.ComboBox();
            this.txtGenreShowsFilm = new System.Windows.Forms.TextBox();
            this.txtProducerShowsFilm = new System.Windows.Forms.TextBox();
            this.lblRatingFilmShowsFilm = new System.Windows.Forms.Label();
            this.lblFormatFilmShowsFilm = new System.Windows.Forms.Label();
            this.lblGenreShowsFilm = new System.Windows.Forms.Label();
            this.lblProducerShowsFilm = new System.Windows.Forms.Label();
            this.btnDeleteShowFilm = new System.Windows.Forms.Button();
            this.btnAddShowFilm = new System.Windows.Forms.Button();
            this.dgvwShowFilm = new System.Windows.Forms.DataGridView();
            this.номерзалаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефильмаDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годвыпускаDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показываетфильмBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showFilmDataSet = new Cinema.ShowFilmDataSet();
            this.txtNameFilmShowFilm = new System.Windows.Forms.TextBox();
            this.lblNameFilmShowFilm = new System.Windows.Forms.Label();
            this.lblYearFilmShowFilm = new System.Windows.Forms.Label();
            this.txtNumHallShowFilm = new System.Windows.Forms.TextBox();
            this.lblNumHallShowFilm = new System.Windows.Forms.Label();
            this.grpPlaceHall = new System.Windows.Forms.GroupBox();
            this.grpAddGroupPlaceHall = new System.Windows.Forms.GroupBox();
            this.txtGroupNumHallPlace = new System.Windows.Forms.TextBox();
            this.txtGroupQuantityPlaceHall = new System.Windows.Forms.TextBox();
            this.txtGroupNumRowHallPlace = new System.Windows.Forms.TextBox();
            this.btnAddGroupPlaceHall = new System.Windows.Forms.Button();
            this.lblGroupQuantityPlaceHall = new System.Windows.Forms.Label();
            this.lblGroupNumRowHallPlace = new System.Windows.Forms.Label();
            this.lblGroupNumHallPlace = new System.Windows.Forms.Label();
            this.grpAddPlaceHall = new System.Windows.Forms.GroupBox();
            this.txtNumHallPlaceHall = new System.Windows.Forms.TextBox();
            this.btnDeletePlaceHall = new System.Windows.Forms.Button();
            this.txtNumPlaceHall = new System.Windows.Forms.TextBox();
            this.txtNumRowPlaceHall = new System.Windows.Forms.TextBox();
            this.btnAddPlaceHall = new System.Windows.Forms.Button();
            this.lblNumPlaceHall = new System.Windows.Forms.Label();
            this.lblNumRowPlaceHall = new System.Windows.Forms.Label();
            this.lblNumHallPlaceHall = new System.Windows.Forms.Label();
            this.dgvwPlaceHall = new System.Windows.Forms.DataGridView();
            this.номерместаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеррядаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзалаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.меставзалеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeInHallDataSet = new Cinema.PlaceInHallDataSet();
            this.grpHall = new System.Windows.Forms.GroupBox();
            this.txtDescriptionHall = new System.Windows.Forms.TextBox();
            this.txtQuantityPlaceHall = new System.Windows.Forms.TextBox();
            this.txtNumHall = new System.Windows.Forms.TextBox();
            this.btnUpdateHall = new System.Windows.Forms.Button();
            this.btnDeleteHall = new System.Windows.Forms.Button();
            this.btnAddHall = new System.Windows.Forms.Button();
            this.lblQuantityPlaceHall = new System.Windows.Forms.Label();
            this.lblDescriptionHall = new System.Windows.Forms.Label();
            this.lblNumHall = new System.Windows.Forms.Label();
            this.dgvwHall = new System.Windows.Forms.DataGridView();
            this.номерзалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниезалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоместDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallDataSet = new Cinema.HallDataSet();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabCashier = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtmPhone = new System.Windows.Forms.MaskedTextBox();
            this.dgvwClient = new System.Windows.Forms.DataGridView();
            this.фИОклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидочнаякартаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet = new Cinema.ClientDataSet();
            this.cboTypeClient = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiscountCard = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiscountCard = new System.Windows.Forms.Label();
            this.lblTypeClient = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.grpTicketPrint = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.picTicket = new System.Windows.Forms.PictureBox();
            this.grpSoldTickets = new System.Windows.Forms.GroupBox();
            this.dgvwSoldTickets = new System.Windows.Forms.DataGridView();
            this.названиефильмаDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годвыпускаDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерместаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеррядаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзалаDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОклиентаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времясеансаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОсотрудникаDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номербилетаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонклиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продажабилетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpSellTicket = new System.Windows.Forms.GroupBox();
            this.lblYearFilmTicket = new System.Windows.Forms.Label();
            this.cboYearFilmTicket = new System.Windows.Forms.ComboBox();
            this.grpHallLayout = new System.Windows.Forms.GroupBox();
            this.dgvwHallTicket = new System.Windows.Forms.DataGridView();
            this.grpSellTicketPlace = new System.Windows.Forms.GroupBox();
            this.lblNumRowTicket = new System.Windows.Forms.Label();
            this.lblNumPlaceTicket = new System.Windows.Forms.Label();
            this.txtmPassportWorkerTicket = new System.Windows.Forms.MaskedTextBox();
            this.txtmPhoneClientTicket = new System.Windows.Forms.MaskedTextBox();
            this.txtNameWorkerTicket = new System.Windows.Forms.TextBox();
            this.txtNameClientTicket = new System.Windows.Forms.TextBox();
            this.lblPhoneClientTicket = new System.Windows.Forms.Label();
            this.lblNameWorkerTicket = new System.Windows.Forms.Label();
            this.lblPassportWorkerTicket = new System.Windows.Forms.Label();
            this.lblNameClientTicket = new System.Windows.Forms.Label();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.txtmCostTicket = new System.Windows.Forms.MaskedTextBox();
            this.txtNumTicket = new System.Windows.Forms.TextBox();
            this.lblCostTicket = new System.Windows.Forms.Label();
            this.lblNumTicket = new System.Windows.Forms.Label();
            this.lblRowSellTicket = new System.Windows.Forms.Label();
            this.lblPlaceSellTicket = new System.Windows.Forms.Label();
            this.cboNumHallTicket = new System.Windows.Forms.ComboBox();
            this.lblNumHallTicket = new System.Windows.Forms.Label();
            this.btnShowFilmTicket = new System.Windows.Forms.Button();
            this.cboDateSessionTicket = new System.Windows.Forms.ComboBox();
            this.cboNameFilmTicket = new System.Windows.Forms.ComboBox();
            this.lblDateSessionTicket = new System.Windows.Forms.Label();
            this.lblNameFilmTicket = new System.Windows.Forms.Label();
            this.grpTicket = new System.Windows.Forms.GroupBox();
            this.lblNumberTicketDelete = new System.Windows.Forms.Label();
            this.lblNumTicketDelete = new System.Windows.Forms.Label();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.dgvwTicket = new System.Windows.Forms.DataGridView();
            this.номербилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценабилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаивремяпродажибилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.билетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketDataSet = new Cinema.TicketDataSet();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabReportTicket = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpLicense = new System.Windows.Forms.GroupBox();
            this.dtmLicenseValidityPeriod = new System.Windows.Forms.DateTimePicker();
            this.dgvwLicense = new System.Windows.Forms.DataGridView();
            this.номерлицензииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьлицензииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниелицензииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сроклицензииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лицензияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lisenseListDataSet = new Cinema.LisenseListDataSet();
            this.txtNumLicense = new System.Windows.Forms.TextBox();
            this.lblNumLicense = new System.Windows.Forms.Label();
            this.btnDeleteLicense = new System.Windows.Forms.Button();
            this.btnUpdateLicense = new System.Windows.Forms.Button();
            this.txtCostLicense = new System.Windows.Forms.TextBox();
            this.btnAddLicense = new System.Windows.Forms.Button();
            this.txtDescriptionLicense = new System.Windows.Forms.TextBox();
            this.lblCostLicense = new System.Windows.Forms.Label();
            this.lblDescriptionLicense = new System.Windows.Forms.Label();
            this.lblValidityLicense = new System.Windows.Forms.Label();
            this.grpAcquisitionLicense = new System.Windows.Forms.GroupBox();
            this.numYearFilmAcquisitionLicense = new System.Windows.Forms.NumericUpDown();
            this.txtmPassportWorkerAcquisitionLicense = new System.Windows.Forms.MaskedTextBox();
            this.txtTitlePostAcquisitionLicense = new System.Windows.Forms.TextBox();
            this.lblTitlePostAcquisitionLicense = new System.Windows.Forms.Label();
            this.dgvwAcquisitionLicense = new System.Windows.Forms.DataGridView();
            this.номерлицензииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годвыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиедолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приобретениелицензииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licenseDataSet = new Cinema.LicenseDataSet();
            this.txtNumAcquisitionLicense = new System.Windows.Forms.TextBox();
            this.lblNumAcquisitionLicense = new System.Windows.Forms.Label();
            this.btnDeleteAcquisitionLicense = new System.Windows.Forms.Button();
            this.txtNameFilmAcquisitionLicense = new System.Windows.Forms.TextBox();
            this.txtNameWorkerAcquisitionLicense = new System.Windows.Forms.TextBox();
            this.btnAddAcquisitionLicense = new System.Windows.Forms.Button();
            this.lblNameFilmAcquisitionLicense = new System.Windows.Forms.Label();
            this.lblYearFilmAcquisitionLicense = new System.Windows.Forms.Label();
            this.lblPassportWorkerAcquisitionLicense = new System.Windows.Forms.Label();
            this.lblNameWorkerAcquisitionLicense = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grpShowingFilm = new System.Windows.Forms.GroupBox();
            this.numYearFilmShowing = new System.Windows.Forms.NumericUpDown();
            this.txtmPassportShowing = new System.Windows.Forms.MaskedTextBox();
            this.txtTitlePostShowing = new System.Windows.Forms.TextBox();
            this.lblTitlePostShowing = new System.Windows.Forms.Label();
            this.dgvwShowingFilm = new System.Windows.Forms.DataGridView();
            this.iDоборудованияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефильмаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годвыпускаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОсотрудникаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиедолжностиDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.показфильмаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showingFilmDataSet = new Cinema.ShowingFilmDataSet();
            this.btnDeleteShowingFilm = new System.Windows.Forms.Button();
            this.btnAddShowingFilm = new System.Windows.Forms.Button();
            this.lblPassportShowing = new System.Windows.Forms.Label();
            this.txtNameWorkerShowing = new System.Windows.Forms.TextBox();
            this.lblNameWorkerShowing = new System.Windows.Forms.Label();
            this.txtNameFilmShowing = new System.Windows.Forms.TextBox();
            this.lblNameFilmShowing = new System.Windows.Forms.Label();
            this.lblYearFilmShowing = new System.Windows.Forms.Label();
            this.txtEquipmentIDFilm = new System.Windows.Forms.TextBox();
            this.lblEquipmentIDFilm = new System.Windows.Forms.Label();
            this.grpEquipment = new System.Windows.Forms.GroupBox();
            this.dgvwEquipment = new System.Windows.Forms.DataGridView();
            this.iDоборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.форматоборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеоборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentDataSet = new Cinema.EquipmentDataSet();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.cboEquipmentFormat = new System.Windows.Forms.ComboBox();
            this.lblEquipmentFormat = new System.Windows.Forms.Label();
            this.txtDescriptionEquipment = new System.Windows.Forms.TextBox();
            this.lblTitleEquipment = new System.Windows.Forms.Label();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabReport = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерзалаDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниезалаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоместDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpWorkerHall = new System.Windows.Forms.GroupBox();
            this.txtNamePostWorkerHall = new System.Windows.Forms.TextBox();
            this.lblNamePostWorkerHall = new System.Windows.Forms.Label();
            this.txtmPassportWorkerHall = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateWorkerHall = new System.Windows.Forms.Button();
            this.btnDeleteWorkerHall = new System.Windows.Forms.Button();
            this.btnAddWorkerHall = new System.Windows.Forms.Button();
            this.dgvwWorkerHall = new System.Windows.Forms.DataGridView();
            this.номерзалаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОсотрудникаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиедолжностиDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникизалаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerHallDataSet = new Cinema.WorkerHallDataSet();
            this.lblPassportWorkerHall = new System.Windows.Forms.Label();
            this.txtNameWorkerHall = new System.Windows.Forms.TextBox();
            this.lblNameWorkerHall = new System.Windows.Forms.Label();
            this.txtNumHallWorkerHall = new System.Windows.Forms.TextBox();
            this.lblNumHallWorkerHall = new System.Windows.Forms.Label();
            this.grpWorker = new System.Windows.Forms.GroupBox();
            this.txtmPassport = new System.Windows.Forms.MaskedTextBox();
            this.txtTitlePostWorker = new System.Windows.Forms.TextBox();
            this.txtmPhoneWorker = new System.Windows.Forms.MaskedTextBox();
            this.dgvwWorker = new System.Windows.Forms.DataGridView();
            this.фИОсотрудникаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиедолжностиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонасотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адрессотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerDataSet = new Cinema.WorkerDataSet();
            this.btnUpdateWorker = new System.Windows.Forms.Button();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneWorker = new System.Windows.Forms.Label();
            this.lblTitlePostWorker = new System.Windows.Forms.Label();
            this.lblPassport = new System.Windows.Forms.Label();
            this.txtNameWorker = new System.Windows.Forms.TextBox();
            this.lblNameWorker = new System.Windows.Forms.Label();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.dgvwPost = new System.Windows.Forms.DataGridView();
            this.названиедолжностиDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниедолжностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postDataSet = new Cinema.PostDataSet();
            this.txtDescriptionPost = new System.Windows.Forms.TextBox();
            this.txtTitlePost = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnUpdatePost = new System.Windows.Forms.Button();
            this.lblTitlePost = new System.Windows.Forms.Label();
            this.lblDescriptionPost = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnDeletePost = new System.Windows.Forms.Button();
            this.btnAddPost = new System.Windows.Forms.Button();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.топфильмовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.залыбезфильмовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.колбилетовзалаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.топклиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.топкассировBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTitleDataSet = new Cinema.PostTitleDataSet();
            this.залBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hallNumberDataSet = new Cinema.HallNumberDataSet();
            this.клиентTableAdapter = new Cinema.ClientDataSetTableAdapters.КлиентTableAdapter();
            this.приобретение_лицензииTableAdapter = new Cinema.LicenseDataSetTableAdapters.Приобретение_лицензииTableAdapter();
            this.оборудованиеTableAdapter = new Cinema.EquipmentDataSetTableAdapters.ОборудованиеTableAdapter();
            this.должностьTableAdapter = new Cinema.PostTitleDataSetTableAdapters.ДолжностьTableAdapter();
            this.сотрудникTableAdapter = new Cinema.WorkerDataSetTableAdapters.СотрудникTableAdapter();
            this.залTableAdapter = new Cinema.HallDataSetTableAdapters.ЗалTableAdapter();
            this.места_в_залеTableAdapter = new Cinema.PlaceInHallDataSetTableAdapters.Места_в_залеTableAdapter();
            this.залTableAdapter1 = new Cinema.HallNumberDataSetTableAdapters.ЗалTableAdapter();
            this.сотрудникTableAdapter1 = new Cinema.EmployeeNameDataSetTableAdapters.СотрудникTableAdapter();
            this.фильмTableAdapter = new Cinema.FilmDataSetTableAdapters.ФильмTableAdapter();
            this.сеансTableAdapter = new Cinema.SessionDataSetTableAdapters.СеансTableAdapter();
            this.сеансы_залаTableAdapter = new Cinema.SessionInHallDataSetTableAdapters.Сеансы_залаTableAdapter();
            this.лицензияTableAdapter = new Cinema.LisenseListDataSetTableAdapters.ЛицензияTableAdapter();
            this.показ_фильмаTableAdapter = new Cinema.ShowingFilmDataSetTableAdapters.Показ_фильмаTableAdapter();
            this.сотрудники_залаTableAdapter = new Cinema.WorkerHallDataSetTableAdapters.Сотрудники_залаTableAdapter();
            this.показывает_фильмTableAdapter = new Cinema.ShowFilmDataSetTableAdapters.Показывает_фильмTableAdapter();
            this.должностьTableAdapter1 = new Cinema.PostDataSetTableAdapters.ДолжностьTableAdapter();
            this.топ_кассировTableAdapter = new Cinema.TopCashierDataSetTableAdapters.Топ_кассировTableAdapter();
            this.топ_клиентовTableAdapter = new Cinema.TopClientDataSetTableAdapters.Топ_клиентовTableAdapter();
            this.топ_фильмовTableAdapter = new Cinema.TopFilmDataSetTableAdapters.Топ_фильмовTableAdapter();
            this.залы_без_фильмовTableAdapter = new Cinema.HallWithoutFilmDataSetTableAdapters.Залы_без_фильмовTableAdapter();
            this.кол_билетов_залаTableAdapter = new Cinema.CountOfTicketDataSetTableAdapters.Кол_билетов_залаTableAdapter();
            this.билетTableAdapter = new Cinema.TicketDataSetTableAdapters.БилетTableAdapter();
            this.продажа_билетовTableAdapter = new Cinema.SoldTicketsDataSetTableAdapters.Продажа_билетовTableAdapter();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.hallNumberDataSet1 = new Cinema.HallNumberDataSet();
            this.hallNumberDataSet2 = new Cinema.HallNumberDataSet();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Топ_фильмовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Залы_без_фильмовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallWithoutFilmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Кол_билетов_залаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfTicketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Топ_клиентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topClientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Продажа_билетовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldTicketsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Топ_кассировBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCashierDataSet)).BeginInit();
            this.tabWorker.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmDataSet)).BeginInit();
            this.tabSession.SuspendLayout();
            this.grpSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).BeginInit();
            this.grpSessionHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearSessionHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSessionHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансызалаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionInHallDataSet)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.grpShowFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFilmShowFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwShowFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.показываетфильмBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFilmDataSet)).BeginInit();
            this.grpPlaceHall.SuspendLayout();
            this.grpAddGroupPlaceHall.SuspendLayout();
            this.grpAddPlaceHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwPlaceHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.меставзалеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeInHallDataSet)).BeginInit();
            this.grpHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallDataSet)).BeginInit();
            this.tabPage15.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabCashier.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.grpTicketPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).BeginInit();
            this.grpSoldTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSoldTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажабилетовBindingSource)).BeginInit();
            this.grpSellTicket.SuspendLayout();
            this.grpHallLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwHallTicket)).BeginInit();
            this.grpSellTicketPlace.SuspendLayout();
            this.grpTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).BeginInit();
            this.tabPage14.SuspendLayout();
            this.tabReportTicket.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лицензияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lisenseListDataSet)).BeginInit();
            this.grpAcquisitionLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFilmAcquisitionLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAcquisitionLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приобретениелицензииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.grpShowingFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFilmShowing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwShowingFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.показфильмаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showingFilmDataSet)).BeginInit();
            this.grpEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpWorkerHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWorkerHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникизалаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerHallDataSet)).BeginInit();
            this.grpWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataSet)).BeginInit();
            this.tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).BeginInit();
            this.tabPage18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.топфильмовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыбезфильмовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.колбилетовзалаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.топклиентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.топкассировBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postTitleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallNumberDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallNumberDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallNumberDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Топ_фильмовBindingSource
            // 
            this.Топ_фильмовBindingSource.DataMember = "Топ_фильмов";
            this.Топ_фильмовBindingSource.DataSource = this.topFilmDataSet;
            // 
            // topFilmDataSet
            // 
            this.topFilmDataSet.DataSetName = "TopFilmDataSet";
            this.topFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Залы_без_фильмовBindingSource
            // 
            this.Залы_без_фильмовBindingSource.DataMember = "Залы_без_фильмов";
            this.Залы_без_фильмовBindingSource.DataSource = this.hallWithoutFilmDataSet;
            // 
            // hallWithoutFilmDataSet
            // 
            this.hallWithoutFilmDataSet.DataSetName = "HallWithoutFilmDataSet";
            this.hallWithoutFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Кол_билетов_залаBindingSource
            // 
            this.Кол_билетов_залаBindingSource.DataMember = "Кол_билетов_зала";
            this.Кол_билетов_залаBindingSource.DataSource = this.countOfTicketDataSet;
            // 
            // countOfTicketDataSet
            // 
            this.countOfTicketDataSet.DataSetName = "CountOfTicketDataSet";
            this.countOfTicketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Топ_клиентовBindingSource
            // 
            this.Топ_клиентовBindingSource.DataMember = "Топ_клиентов";
            this.Топ_клиентовBindingSource.DataSource = this.topClientDataSet;
            // 
            // topClientDataSet
            // 
            this.topClientDataSet.DataSetName = "TopClientDataSet";
            this.topClientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Продажа_билетовBindingSource
            // 
            this.Продажа_билетовBindingSource.DataMember = "Продажа_билетов";
            this.Продажа_билетовBindingSource.DataSource = this.soldTicketsDataSet;
            // 
            // soldTicketsDataSet
            // 
            this.soldTicketsDataSet.DataSetName = "SoldTicketsDataSet";
            this.soldTicketsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Топ_кассировBindingSource
            // 
            this.Топ_кассировBindingSource.DataMember = "Топ_кассиров";
            this.Топ_кассировBindingSource.DataSource = this.topCashierDataSet;
            // 
            // topCashierDataSet
            // 
            this.topCashierDataSet.DataSetName = "TopCashierDataSet";
            this.topCashierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabWorker
            // 
            this.tabWorker.Controls.Add(this.tabPage1);
            this.tabWorker.Controls.Add(this.tabPage2);
            this.tabWorker.Controls.Add(this.tabPage3);
            this.tabWorker.Controls.Add(this.tabPage4);
            this.tabWorker.Controls.Add(this.tabPage5);
            this.tabWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWorker.Location = new System.Drawing.Point(0, 0);
            this.tabWorker.Name = "tabWorker";
            this.tabWorker.SelectedIndex = 0;
            this.tabWorker.Size = new System.Drawing.Size(1206, 689);
            this.tabWorker.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabAdmin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1198, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Администратор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabFilm);
            this.tabAdmin.Controls.Add(this.tabSession);
            this.tabAdmin.Controls.Add(this.tabPage10);
            this.tabAdmin.Controls.Add(this.tabPage15);
            this.tabAdmin.Controls.Add(this.tabPage16);
            this.tabAdmin.Controls.Add(this.tabPage17);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Location = new System.Drawing.Point(3, 3);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1192, 657);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabFilm
            // 
            this.tabFilm.Controls.Add(this.numYearFilm);
            this.tabFilm.Controls.Add(this.btnUpdateFilm);
            this.tabFilm.Controls.Add(this.btnDeleteFilm);
            this.tabFilm.Controls.Add(this.btnAddFilm);
            this.tabFilm.Controls.Add(this.dgvwFilm);
            this.tabFilm.Controls.Add(this.cboRating);
            this.tabFilm.Controls.Add(this.cboFormatFilm);
            this.tabFilm.Controls.Add(this.txtGenre);
            this.tabFilm.Controls.Add(this.txtProducer);
            this.tabFilm.Controls.Add(this.txtNameFilm);
            this.tabFilm.Controls.Add(this.lblRating);
            this.tabFilm.Controls.Add(this.lblFormatFilm);
            this.tabFilm.Controls.Add(this.lblGenre);
            this.tabFilm.Controls.Add(this.lblProducer);
            this.tabFilm.Controls.Add(this.lblNameFilm);
            this.tabFilm.Controls.Add(this.lblYearFilm);
            this.tabFilm.Location = new System.Drawing.Point(4, 22);
            this.tabFilm.Name = "tabFilm";
            this.tabFilm.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilm.Size = new System.Drawing.Size(1184, 631);
            this.tabFilm.TabIndex = 0;
            this.tabFilm.Text = "Фильм";
            this.tabFilm.UseVisualStyleBackColor = true;
            // 
            // numYearFilm
            // 
            this.numYearFilm.CausesValidation = false;
            this.numYearFilm.Location = new System.Drawing.Point(10, 90);
            this.numYearFilm.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numYearFilm.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearFilm.Name = "numYearFilm";
            this.numYearFilm.ReadOnly = true;
            this.numYearFilm.Size = new System.Drawing.Size(236, 20);
            this.numYearFilm.TabIndex = 46;
            this.numYearFilm.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // btnUpdateFilm
            // 
            this.btnUpdateFilm.CausesValidation = false;
            this.btnUpdateFilm.Location = new System.Drawing.Point(88, 403);
            this.btnUpdateFilm.Name = "btnUpdateFilm";
            this.btnUpdateFilm.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFilm.TabIndex = 44;
            this.btnUpdateFilm.Text = "Обновить";
            this.btnUpdateFilm.UseVisualStyleBackColor = true;
            this.btnUpdateFilm.Click += new System.EventHandler(this.btnUpdateFilm_Click);
            // 
            // btnDeleteFilm
            // 
            this.btnDeleteFilm.CausesValidation = false;
            this.btnDeleteFilm.Location = new System.Drawing.Point(169, 403);
            this.btnDeleteFilm.Name = "btnDeleteFilm";
            this.btnDeleteFilm.Size = new System.Drawing.Size(77, 23);
            this.btnDeleteFilm.TabIndex = 43;
            this.btnDeleteFilm.Text = "Удалить";
            this.btnDeleteFilm.UseVisualStyleBackColor = true;
            this.btnDeleteFilm.Click += new System.EventHandler(this.btnDeleteFilm_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.CausesValidation = false;
            this.btnAddFilm.Location = new System.Drawing.Point(9, 403);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilm.TabIndex = 42;
            this.btnAddFilm.Text = "Добавить";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // dgvwFilm
            // 
            this.dgvwFilm.AllowUserToAddRows = false;
            this.dgvwFilm.AllowUserToDeleteRows = false;
            this.dgvwFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwFilm.AutoGenerateColumns = false;
            this.dgvwFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwFilm.CausesValidation = false;
            this.dgvwFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиефильмаDataGridViewTextBoxColumn1,
            this.годвыпускаDataGridViewTextBoxColumn1,
            this.режиссёрDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.форматDataGridViewTextBoxColumn,
            this.рейтингDataGridViewTextBoxColumn});
            this.dgvwFilm.DataSource = this.фильмBindingSource;
            this.dgvwFilm.Location = new System.Drawing.Point(269, 6);
            this.dgvwFilm.Name = "dgvwFilm";
            this.dgvwFilm.ReadOnly = true;
            this.dgvwFilm.Size = new System.Drawing.Size(909, 619);
            this.dgvwFilm.TabIndex = 12;
            this.dgvwFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwFilm_CellClick);
            // 
            // названиефильмаDataGridViewTextBoxColumn1
            // 
            this.названиефильмаDataGridViewTextBoxColumn1.DataPropertyName = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn1.HeaderText = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn1.Name = "названиефильмаDataGridViewTextBoxColumn1";
            this.названиефильмаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.названиефильмаDataGridViewTextBoxColumn1.Width = 128;
            // 
            // годвыпускаDataGridViewTextBoxColumn1
            // 
            this.годвыпускаDataGridViewTextBoxColumn1.DataPropertyName = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn1.HeaderText = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn1.Name = "годвыпускаDataGridViewTextBoxColumn1";
            this.годвыпускаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.годвыпускаDataGridViewTextBoxColumn1.Width = 99;
            // 
            // режиссёрDataGridViewTextBoxColumn
            // 
            this.режиссёрDataGridViewTextBoxColumn.DataPropertyName = "Режиссёр";
            this.режиссёрDataGridViewTextBoxColumn.HeaderText = "Режиссёр";
            this.режиссёрDataGridViewTextBoxColumn.Name = "режиссёрDataGridViewTextBoxColumn";
            this.режиссёрDataGridViewTextBoxColumn.ReadOnly = true;
            this.режиссёрDataGridViewTextBoxColumn.Width = 83;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.ReadOnly = true;
            this.жанрDataGridViewTextBoxColumn.Width = 61;
            // 
            // форматDataGridViewTextBoxColumn
            // 
            this.форматDataGridViewTextBoxColumn.DataPropertyName = "Формат";
            this.форматDataGridViewTextBoxColumn.HeaderText = "Формат";
            this.форматDataGridViewTextBoxColumn.Name = "форматDataGridViewTextBoxColumn";
            this.форматDataGridViewTextBoxColumn.ReadOnly = true;
            this.форматDataGridViewTextBoxColumn.Width = 74;
            // 
            // рейтингDataGridViewTextBoxColumn
            // 
            this.рейтингDataGridViewTextBoxColumn.DataPropertyName = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.рейтингDataGridViewTextBoxColumn.Name = "рейтингDataGridViewTextBoxColumn";
            this.рейтингDataGridViewTextBoxColumn.ReadOnly = true;
            this.рейтингDataGridViewTextBoxColumn.Width = 73;
            // 
            // фильмBindingSource
            // 
            this.фильмBindingSource.DataMember = "Фильм";
            this.фильмBindingSource.DataSource = this.filmDataSet;
            // 
            // filmDataSet
            // 
            this.filmDataSet.DataSetName = "FilmDataSet";
            this.filmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboRating
            // 
            this.cboRating.CausesValidation = false;
            this.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRating.FormattingEnabled = true;
            this.cboRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17"});
            this.cboRating.Location = new System.Drawing.Point(9, 363);
            this.cboRating.Name = "cboRating";
            this.cboRating.Size = new System.Drawing.Size(237, 21);
            this.cboRating.TabIndex = 11;
            this.cboRating.Validating += new System.ComponentModel.CancelEventHandler(this.cboRating_Validating);
            // 
            // cboFormatFilm
            // 
            this.cboFormatFilm.CausesValidation = false;
            this.cboFormatFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormatFilm.FormattingEnabled = true;
            this.cboFormatFilm.Items.AddRange(new object[] {
            "2D",
            "2D IMAX",
            "3D",
            "3D IMAX"});
            this.cboFormatFilm.Location = new System.Drawing.Point(9, 292);
            this.cboFormatFilm.Name = "cboFormatFilm";
            this.cboFormatFilm.Size = new System.Drawing.Size(237, 21);
            this.cboFormatFilm.TabIndex = 10;
            this.cboFormatFilm.Validating += new System.ComponentModel.CancelEventHandler(this.cboFormatFilm_Validating);
            // 
            // txtGenre
            // 
            this.txtGenre.CausesValidation = false;
            this.txtGenre.Location = new System.Drawing.Point(10, 220);
            this.txtGenre.MaxLength = 50;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(236, 20);
            this.txtGenre.TabIndex = 9;
            this.txtGenre.Validating += new System.ComponentModel.CancelEventHandler(this.txtGenre_Validating);
            // 
            // txtProducer
            // 
            this.txtProducer.CausesValidation = false;
            this.txtProducer.Location = new System.Drawing.Point(9, 154);
            this.txtProducer.MaxLength = 50;
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(237, 20);
            this.txtProducer.TabIndex = 8;
            this.txtProducer.Validating += new System.ComponentModel.CancelEventHandler(this.txtProducer_Validating);
            // 
            // txtNameFilm
            // 
            this.txtNameFilm.CausesValidation = false;
            this.txtNameFilm.Location = new System.Drawing.Point(9, 29);
            this.txtNameFilm.MaxLength = 50;
            this.txtNameFilm.Name = "txtNameFilm";
            this.txtNameFilm.Size = new System.Drawing.Size(237, 20);
            this.txtNameFilm.TabIndex = 6;
            this.txtNameFilm.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameFilm_Validating);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(6, 347);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(48, 13);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = "Рейтинг";
            // 
            // lblFormatFilm
            // 
            this.lblFormatFilm.AutoSize = true;
            this.lblFormatFilm.Location = new System.Drawing.Point(6, 276);
            this.lblFormatFilm.Name = "lblFormatFilm";
            this.lblFormatFilm.Size = new System.Drawing.Size(49, 13);
            this.lblFormatFilm.TabIndex = 4;
            this.lblFormatFilm.Text = "Формат";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(7, 204);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Жанр";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(6, 138);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(58, 13);
            this.lblProducer.TabIndex = 2;
            this.lblProducer.Text = "Режиссёр";
            // 
            // lblNameFilm
            // 
            this.lblNameFilm.AutoSize = true;
            this.lblNameFilm.Location = new System.Drawing.Point(6, 13);
            this.lblNameFilm.Name = "lblNameFilm";
            this.lblNameFilm.Size = new System.Drawing.Size(100, 13);
            this.lblNameFilm.TabIndex = 1;
            this.lblNameFilm.Text = "Название фильма";
            // 
            // lblYearFilm
            // 
            this.lblYearFilm.AutoSize = true;
            this.lblYearFilm.Location = new System.Drawing.Point(6, 74);
            this.lblYearFilm.Name = "lblYearFilm";
            this.lblYearFilm.Size = new System.Drawing.Size(71, 13);
            this.lblYearFilm.TabIndex = 0;
            this.lblYearFilm.Text = "Год выпуска";
            // 
            // tabSession
            // 
            this.tabSession.Controls.Add(this.grpSession);
            this.tabSession.Controls.Add(this.grpSessionHall);
            this.tabSession.Location = new System.Drawing.Point(4, 22);
            this.tabSession.Name = "tabSession";
            this.tabSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabSession.Size = new System.Drawing.Size(1184, 631);
            this.tabSession.TabIndex = 1;
            this.tabSession.Text = "Сеансы";
            this.tabSession.UseVisualStyleBackColor = true;
            // 
            // grpSession
            // 
            this.grpSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSession.Controls.Add(this.numYearSession);
            this.grpSession.Controls.Add(this.dtmTimeSession);
            this.grpSession.Controls.Add(this.dgvwSession);
            this.grpSession.Controls.Add(this.lblTimeSession);
            this.grpSession.Controls.Add(this.btnDeleteSession);
            this.grpSession.Controls.Add(this.btnUpdateSession);
            this.grpSession.Controls.Add(this.lblNameFilmSession);
            this.grpSession.Controls.Add(this.txtNameFilmSession);
            this.grpSession.Controls.Add(this.btnAddSession);
            this.grpSession.Controls.Add(this.lblYearFilmSession);
            this.grpSession.Location = new System.Drawing.Point(6, 3);
            this.grpSession.Name = "grpSession";
            this.grpSession.Size = new System.Drawing.Size(1172, 305);
            this.grpSession.TabIndex = 73;
            this.grpSession.TabStop = false;
            this.grpSession.Text = "Сеансы";
            // 
            // numYearSession
            // 
            this.numYearSession.CausesValidation = false;
            this.numYearSession.Location = new System.Drawing.Point(6, 166);
            this.numYearSession.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numYearSession.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearSession.Name = "numYearSession";
            this.numYearSession.ReadOnly = true;
            this.numYearSession.Size = new System.Drawing.Size(222, 20);
            this.numYearSession.TabIndex = 55;
            this.numYearSession.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // dtmTimeSession
            // 
            this.dtmTimeSession.CausesValidation = false;
            this.dtmTimeSession.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtmTimeSession.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmTimeSession.Location = new System.Drawing.Point(6, 36);
            this.dtmTimeSession.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtmTimeSession.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtmTimeSession.Name = "dtmTimeSession";
            this.dtmTimeSession.Size = new System.Drawing.Size(222, 20);
            this.dtmTimeSession.TabIndex = 54;
            this.dtmTimeSession.Enter += new System.EventHandler(this.dtmTimeSession_Enter);
            // 
            // dgvwSession
            // 
            this.dgvwSession.AllowUserToAddRows = false;
            this.dgvwSession.AllowUserToDeleteRows = false;
            this.dgvwSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwSession.AutoGenerateColumns = false;
            this.dgvwSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwSession.CausesValidation = false;
            this.dgvwSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.времясеансаDataGridViewTextBoxColumn,
            this.названиефильмаDataGridViewTextBoxColumn2,
            this.годвыпускаDataGridViewTextBoxColumn2});
            this.dgvwSession.DataSource = this.сеансBindingSource;
            this.dgvwSession.Location = new System.Drawing.Point(248, 18);
            this.dgvwSession.Name = "dgvwSession";
            this.dgvwSession.ReadOnly = true;
            this.dgvwSession.Size = new System.Drawing.Size(918, 281);
            this.dgvwSession.TabIndex = 53;
            this.dgvwSession.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwSession_CellClick);
            // 
            // времясеансаDataGridViewTextBoxColumn
            // 
            this.времясеансаDataGridViewTextBoxColumn.DataPropertyName = "Время_сеанса";
            this.времясеансаDataGridViewTextBoxColumn.HeaderText = "Время_сеанса";
            this.времясеансаDataGridViewTextBoxColumn.Name = "времясеансаDataGridViewTextBoxColumn";
            this.времясеансаDataGridViewTextBoxColumn.ReadOnly = true;
            this.времясеансаDataGridViewTextBoxColumn.Width = 107;
            // 
            // названиефильмаDataGridViewTextBoxColumn2
            // 
            this.названиефильмаDataGridViewTextBoxColumn2.DataPropertyName = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn2.HeaderText = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn2.Name = "названиефильмаDataGridViewTextBoxColumn2";
            this.названиефильмаDataGridViewTextBoxColumn2.ReadOnly = true;
            this.названиефильмаDataGridViewTextBoxColumn2.Width = 128;
            // 
            // годвыпускаDataGridViewTextBoxColumn2
            // 
            this.годвыпускаDataGridViewTextBoxColumn2.DataPropertyName = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn2.HeaderText = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn2.Name = "годвыпускаDataGridViewTextBoxColumn2";
            this.годвыпускаDataGridViewTextBoxColumn2.ReadOnly = true;
            this.годвыпускаDataGridViewTextBoxColumn2.Width = 99;
            // 
            // сеансBindingSource
            // 
            this.сеансBindingSource.DataMember = "Сеанс";
            this.сеансBindingSource.DataSource = this.sessionDataSet;
            // 
            // sessionDataSet
            // 
            this.sessionDataSet.DataSetName = "SessionDataSet";
            this.sessionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTimeSession
            // 
            this.lblTimeSession.AutoSize = true;
            this.lblTimeSession.Location = new System.Drawing.Point(3, 20);
            this.lblTimeSession.Name = "lblTimeSession";
            this.lblTimeSession.Size = new System.Drawing.Size(79, 13);
            this.lblTimeSession.TabIndex = 44;
            this.lblTimeSession.Text = "Время сеанса";
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.CausesValidation = false;
            this.btnDeleteSession.Location = new System.Drawing.Point(160, 210);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(68, 23);
            this.btnDeleteSession.TabIndex = 49;
            this.btnDeleteSession.Text = "Удалить";
            this.btnDeleteSession.UseVisualStyleBackColor = true;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // btnUpdateSession
            // 
            this.btnUpdateSession.CausesValidation = false;
            this.btnUpdateSession.Location = new System.Drawing.Point(81, 210);
            this.btnUpdateSession.Name = "btnUpdateSession";
            this.btnUpdateSession.Size = new System.Drawing.Size(73, 23);
            this.btnUpdateSession.TabIndex = 51;
            this.btnUpdateSession.Text = "Обновить";
            this.btnUpdateSession.UseVisualStyleBackColor = true;
            this.btnUpdateSession.Click += new System.EventHandler(this.btnUpdateSession_Click);
            // 
            // lblNameFilmSession
            // 
            this.lblNameFilmSession.AutoSize = true;
            this.lblNameFilmSession.Location = new System.Drawing.Point(3, 82);
            this.lblNameFilmSession.Name = "lblNameFilmSession";
            this.lblNameFilmSession.Size = new System.Drawing.Size(100, 13);
            this.lblNameFilmSession.TabIndex = 46;
            this.lblNameFilmSession.Text = "Название фильма";
            // 
            // txtNameFilmSession
            // 
            this.txtNameFilmSession.CausesValidation = false;
            this.txtNameFilmSession.Location = new System.Drawing.Point(6, 98);
            this.txtNameFilmSession.MaxLength = 50;
            this.txtNameFilmSession.Name = "txtNameFilmSession";
            this.txtNameFilmSession.Size = new System.Drawing.Size(222, 20);
            this.txtNameFilmSession.TabIndex = 52;
            this.txtNameFilmSession.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameFilmSession_Validating);
            // 
            // btnAddSession
            // 
            this.btnAddSession.CausesValidation = false;
            this.btnAddSession.Location = new System.Drawing.Point(6, 210);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(69, 23);
            this.btnAddSession.TabIndex = 48;
            this.btnAddSession.Text = "Добавить";
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // lblYearFilmSession
            // 
            this.lblYearFilmSession.AutoSize = true;
            this.lblYearFilmSession.Location = new System.Drawing.Point(3, 150);
            this.lblYearFilmSession.Name = "lblYearFilmSession";
            this.lblYearFilmSession.Size = new System.Drawing.Size(71, 13);
            this.lblYearFilmSession.TabIndex = 47;
            this.lblYearFilmSession.Text = "Год выпуска";
            // 
            // grpSessionHall
            // 
            this.grpSessionHall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSessionHall.Controls.Add(this.numYearSessionHall);
            this.grpSessionHall.Controls.Add(this.lblNameFilmSessionHall);
            this.grpSessionHall.Controls.Add(this.txtNameFilmSessionHall);
            this.grpSessionHall.Controls.Add(this.lblYearFilmSessionHall);
            this.grpSessionHall.Controls.Add(this.dtmTimeSessionHall);
            this.grpSessionHall.Controls.Add(this.dgvwSessionHall);
            this.grpSessionHall.Controls.Add(this.txtNumHallSessionHall);
            this.grpSessionHall.Controls.Add(this.lblTimeSessionHall);
            this.grpSessionHall.Controls.Add(this.btnDeleteSessionHall);
            this.grpSessionHall.Controls.Add(this.lblNumHallSessionHall);
            this.grpSessionHall.Controls.Add(this.btnAddSessionHall);
            this.grpSessionHall.Location = new System.Drawing.Point(6, 314);
            this.grpSessionHall.Name = "grpSessionHall";
            this.grpSessionHall.Size = new System.Drawing.Size(1172, 311);
            this.grpSessionHall.TabIndex = 74;
            this.grpSessionHall.TabStop = false;
            this.grpSessionHall.Text = "Сеансы зала";
            // 
            // numYearSessionHall
            // 
            this.numYearSessionHall.CausesValidation = false;
            this.numYearSessionHall.Location = new System.Drawing.Point(6, 207);
            this.numYearSessionHall.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numYearSessionHall.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearSessionHall.Name = "numYearSessionHall";
            this.numYearSessionHall.ReadOnly = true;
            this.numYearSessionHall.Size = new System.Drawing.Size(222, 20);
            this.numYearSessionHall.TabIndex = 79;
            this.numYearSessionHall.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // lblNameFilmSessionHall
            // 
            this.lblNameFilmSessionHall.AutoSize = true;
            this.lblNameFilmSessionHall.Location = new System.Drawing.Point(3, 125);
            this.lblNameFilmSessionHall.Name = "lblNameFilmSessionHall";
            this.lblNameFilmSessionHall.Size = new System.Drawing.Size(100, 13);
            this.lblNameFilmSessionHall.TabIndex = 75;
            this.lblNameFilmSessionHall.Text = "Название фильма";
            // 
            // txtNameFilmSessionHall
            // 
            this.txtNameFilmSessionHall.CausesValidation = false;
            this.txtNameFilmSessionHall.Location = new System.Drawing.Point(6, 141);
            this.txtNameFilmSessionHall.MaxLength = 50;
            this.txtNameFilmSessionHall.Name = "txtNameFilmSessionHall";
            this.txtNameFilmSessionHall.Size = new System.Drawing.Size(222, 20);
            this.txtNameFilmSessionHall.TabIndex = 77;
            this.txtNameFilmSessionHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameFilmSessionHall_Validating);
            // 
            // lblYearFilmSessionHall
            // 
            this.lblYearFilmSessionHall.AutoSize = true;
            this.lblYearFilmSessionHall.Location = new System.Drawing.Point(2, 180);
            this.lblYearFilmSessionHall.Name = "lblYearFilmSessionHall";
            this.lblYearFilmSessionHall.Size = new System.Drawing.Size(71, 13);
            this.lblYearFilmSessionHall.TabIndex = 76;
            this.lblYearFilmSessionHall.Text = "Год выпуска";
            // 
            // dtmTimeSessionHall
            // 
            this.dtmTimeSessionHall.CausesValidation = false;
            this.dtmTimeSessionHall.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtmTimeSessionHall.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmTimeSessionHall.Location = new System.Drawing.Point(6, 35);
            this.dtmTimeSessionHall.Name = "dtmTimeSessionHall";
            this.dtmTimeSessionHall.Size = new System.Drawing.Size(222, 20);
            this.dtmTimeSessionHall.TabIndex = 74;
            this.dtmTimeSessionHall.Enter += new System.EventHandler(this.dtmTimeSessionHall_Enter);
            // 
            // dgvwSessionHall
            // 
            this.dgvwSessionHall.AllowUserToAddRows = false;
            this.dgvwSessionHall.AllowUserToDeleteRows = false;
            this.dgvwSessionHall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwSessionHall.AutoGenerateColumns = false;
            this.dgvwSessionHall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwSessionHall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwSessionHall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvwSessionHall.DataSource = this.сеансызалаBindingSource;
            this.dgvwSessionHall.Location = new System.Drawing.Point(248, 15);
            this.dgvwSessionHall.Name = "dgvwSessionHall";
            this.dgvwSessionHall.ReadOnly = true;
            this.dgvwSessionHall.Size = new System.Drawing.Size(918, 290);
            this.dgvwSessionHall.TabIndex = 73;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_зала";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_зала";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 96;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Время_сеанса";
            this.dataGridViewTextBoxColumn2.HeaderText = "Время_сеанса";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 107;
            // 
            // сеансызалаBindingSource
            // 
            this.сеансызалаBindingSource.DataMember = "Сеансы_зала";
            this.сеансызалаBindingSource.DataSource = this.sessionInHallDataSet;
            // 
            // sessionInHallDataSet
            // 
            this.sessionInHallDataSet.DataSetName = "SessionInHallDataSet";
            this.sessionInHallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumHallSessionHall
            // 
            this.txtNumHallSessionHall.CausesValidation = false;
            this.txtNumHallSessionHall.Location = new System.Drawing.Point(5, 84);
            this.txtNumHallSessionHall.MaxLength = 3;
            this.txtNumHallSessionHall.Name = "txtNumHallSessionHall";
            this.txtNumHallSessionHall.Size = new System.Drawing.Size(223, 20);
            this.txtNumHallSessionHall.TabIndex = 71;
            this.txtNumHallSessionHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumHallSessionHall_KeyPress);
            this.txtNumHallSessionHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumHallSessionHall_Validating);
            // 
            // lblTimeSessionHall
            // 
            this.lblTimeSessionHall.AutoSize = true;
            this.lblTimeSessionHall.Location = new System.Drawing.Point(2, 19);
            this.lblTimeSessionHall.Name = "lblTimeSessionHall";
            this.lblTimeSessionHall.Size = new System.Drawing.Size(79, 13);
            this.lblTimeSessionHall.TabIndex = 66;
            this.lblTimeSessionHall.Text = "Время сеанса";
            // 
            // btnDeleteSessionHall
            // 
            this.btnDeleteSessionHall.Location = new System.Drawing.Point(117, 233);
            this.btnDeleteSessionHall.Name = "btnDeleteSessionHall";
            this.btnDeleteSessionHall.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteSessionHall.TabIndex = 69;
            this.btnDeleteSessionHall.Text = "Удалить";
            this.btnDeleteSessionHall.UseVisualStyleBackColor = true;
            this.btnDeleteSessionHall.Click += new System.EventHandler(this.btnDeleteSessionHall_Click);
            // 
            // lblNumHallSessionHall
            // 
            this.lblNumHallSessionHall.AutoSize = true;
            this.lblNumHallSessionHall.Location = new System.Drawing.Point(3, 68);
            this.lblNumHallSessionHall.Name = "lblNumHallSessionHall";
            this.lblNumHallSessionHall.Size = new System.Drawing.Size(68, 13);
            this.lblNumHallSessionHall.TabIndex = 70;
            this.lblNumHallSessionHall.Text = "Номер зала";
            // 
            // btnAddSessionHall
            // 
            this.btnAddSessionHall.Location = new System.Drawing.Point(4, 233);
            this.btnAddSessionHall.Name = "btnAddSessionHall";
            this.btnAddSessionHall.Size = new System.Drawing.Size(107, 23);
            this.btnAddSessionHall.TabIndex = 68;
            this.btnAddSessionHall.Text = "Добавить";
            this.btnAddSessionHall.UseVisualStyleBackColor = true;
            this.btnAddSessionHall.Click += new System.EventHandler(this.btnAddSessionHall_Click);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.grpShowFilm);
            this.tabPage10.Controls.Add(this.grpPlaceHall);
            this.tabPage10.Controls.Add(this.grpHall);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1184, 631);
            this.tabPage10.TabIndex = 2;
            this.tabPage10.Text = "Зал";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // grpShowFilm
            // 
            this.grpShowFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpShowFilm.Controls.Add(this.numYearFilmShowFilm);
            this.grpShowFilm.Controls.Add(this.cboRatingFilmShowsFilm);
            this.grpShowFilm.Controls.Add(this.cboFormatFilmShowsFilm);
            this.grpShowFilm.Controls.Add(this.txtGenreShowsFilm);
            this.grpShowFilm.Controls.Add(this.txtProducerShowsFilm);
            this.grpShowFilm.Controls.Add(this.lblRatingFilmShowsFilm);
            this.grpShowFilm.Controls.Add(this.lblFormatFilmShowsFilm);
            this.grpShowFilm.Controls.Add(this.lblGenreShowsFilm);
            this.grpShowFilm.Controls.Add(this.lblProducerShowsFilm);
            this.grpShowFilm.Controls.Add(this.btnDeleteShowFilm);
            this.grpShowFilm.Controls.Add(this.btnAddShowFilm);
            this.grpShowFilm.Controls.Add(this.dgvwShowFilm);
            this.grpShowFilm.Controls.Add(this.txtNameFilmShowFilm);
            this.grpShowFilm.Controls.Add(this.lblNameFilmShowFilm);
            this.grpShowFilm.Controls.Add(this.lblYearFilmShowFilm);
            this.grpShowFilm.Controls.Add(this.txtNumHallShowFilm);
            this.grpShowFilm.Controls.Add(this.lblNumHallShowFilm);
            this.grpShowFilm.Location = new System.Drawing.Point(6, 201);
            this.grpShowFilm.Name = "grpShowFilm";
            this.grpShowFilm.Size = new System.Drawing.Size(620, 430);
            this.grpShowFilm.TabIndex = 47;
            this.grpShowFilm.TabStop = false;
            this.grpShowFilm.Text = "Показываемые фильмы";
            // 
            // numYearFilmShowFilm
            // 
            this.numYearFilmShowFilm.CausesValidation = false;
            this.numYearFilmShowFilm.Location = new System.Drawing.Point(6, 137);
            this.numYearFilmShowFilm.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numYearFilmShowFilm.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearFilmShowFilm.Name = "numYearFilmShowFilm";
            this.numYearFilmShowFilm.ReadOnly = true;
            this.numYearFilmShowFilm.Size = new System.Drawing.Size(208, 20);
            this.numYearFilmShowFilm.TabIndex = 66;
            this.numYearFilmShowFilm.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // cboRatingFilmShowsFilm
            // 
            this.cboRatingFilmShowsFilm.CausesValidation = false;
            this.cboRatingFilmShowsFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRatingFilmShowsFilm.FormattingEnabled = true;
            this.cboRatingFilmShowsFilm.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17"});
            this.cboRatingFilmShowsFilm.Location = new System.Drawing.Point(6, 335);
            this.cboRatingFilmShowsFilm.Name = "cboRatingFilmShowsFilm";
            this.cboRatingFilmShowsFilm.Size = new System.Drawing.Size(207, 21);
            this.cboRatingFilmShowsFilm.TabIndex = 65;
            this.cboRatingFilmShowsFilm.Validating += new System.ComponentModel.CancelEventHandler(this.cboRatingFilmShowsFilm_Validating);
            // 
            // cboFormatFilmShowsFilm
            // 
            this.cboFormatFilmShowsFilm.CausesValidation = false;
            this.cboFormatFilmShowsFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormatFilmShowsFilm.FormattingEnabled = true;
            this.cboFormatFilmShowsFilm.Items.AddRange(new object[] {
            "2D",
            "2D IMAX",
            "3D",
            "3D IMAX"});
            this.cboFormatFilmShowsFilm.Location = new System.Drawing.Point(5, 281);
            this.cboFormatFilmShowsFilm.Name = "cboFormatFilmShowsFilm";
            this.cboFormatFilmShowsFilm.Size = new System.Drawing.Size(207, 21);
            this.cboFormatFilmShowsFilm.TabIndex = 64;
            this.cboFormatFilmShowsFilm.Validating += new System.ComponentModel.CancelEventHandler(this.cboFormatFilmShowsFilm_Validating);
            // 
            // txtGenreShowsFilm
            // 
            this.txtGenreShowsFilm.CausesValidation = false;
            this.txtGenreShowsFilm.Location = new System.Drawing.Point(6, 232);
            this.txtGenreShowsFilm.Name = "txtGenreShowsFilm";
            this.txtGenreShowsFilm.Size = new System.Drawing.Size(206, 20);
            this.txtGenreShowsFilm.TabIndex = 63;
            this.txtGenreShowsFilm.Validating += new System.ComponentModel.CancelEventHandler(this.txtGenreShowsFilm_Validating);
            // 
            // txtProducerShowsFilm
            // 
            this.txtProducerShowsFilm.CausesValidation = false;
            this.txtProducerShowsFilm.Location = new System.Drawing.Point(6, 184);
            this.txtProducerShowsFilm.Name = "txtProducerShowsFilm";
            this.txtProducerShowsFilm.Size = new System.Drawing.Size(208, 20);
            this.txtProducerShowsFilm.TabIndex = 62;
            this.txtProducerShowsFilm.Validating += new System.ComponentModel.CancelEventHandler(this.txtProducerShowsFilm_Validating);
            // 
            // lblRatingFilmShowsFilm
            // 
            this.lblRatingFilmShowsFilm.AutoSize = true;
            this.lblRatingFilmShowsFilm.Location = new System.Drawing.Point(3, 319);
            this.lblRatingFilmShowsFilm.Name = "lblRatingFilmShowsFilm";
            this.lblRatingFilmShowsFilm.Size = new System.Drawing.Size(48, 13);
            this.lblRatingFilmShowsFilm.TabIndex = 61;
            this.lblRatingFilmShowsFilm.Text = "Рейтинг";
            // 
            // lblFormatFilmShowsFilm
            // 
            this.lblFormatFilmShowsFilm.AutoSize = true;
            this.lblFormatFilmShowsFilm.Location = new System.Drawing.Point(2, 265);
            this.lblFormatFilmShowsFilm.Name = "lblFormatFilmShowsFilm";
            this.lblFormatFilmShowsFilm.Size = new System.Drawing.Size(49, 13);
            this.lblFormatFilmShowsFilm.TabIndex = 60;
            this.lblFormatFilmShowsFilm.Text = "Формат";
            // 
            // lblGenreShowsFilm
            // 
            this.lblGenreShowsFilm.AutoSize = true;
            this.lblGenreShowsFilm.Location = new System.Drawing.Point(2, 216);
            this.lblGenreShowsFilm.Name = "lblGenreShowsFilm";
            this.lblGenreShowsFilm.Size = new System.Drawing.Size(36, 13);
            this.lblGenreShowsFilm.TabIndex = 59;
            this.lblGenreShowsFilm.Text = "Жанр";
            // 
            // lblProducerShowsFilm
            // 
            this.lblProducerShowsFilm.AutoSize = true;
            this.lblProducerShowsFilm.Location = new System.Drawing.Point(3, 168);
            this.lblProducerShowsFilm.Name = "lblProducerShowsFilm";
            this.lblProducerShowsFilm.Size = new System.Drawing.Size(58, 13);
            this.lblProducerShowsFilm.TabIndex = 58;
            this.lblProducerShowsFilm.Text = "Режиссёр";
            // 
            // btnDeleteShowFilm
            // 
            this.btnDeleteShowFilm.Location = new System.Drawing.Point(109, 386);
            this.btnDeleteShowFilm.Name = "btnDeleteShowFilm";
            this.btnDeleteShowFilm.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteShowFilm.TabIndex = 56;
            this.btnDeleteShowFilm.Text = "Удалить";
            this.btnDeleteShowFilm.UseVisualStyleBackColor = true;
            this.btnDeleteShowFilm.Click += new System.EventHandler(this.btnDeleteShowFilm_Click);
            // 
            // btnAddShowFilm
            // 
            this.btnAddShowFilm.Location = new System.Drawing.Point(5, 386);
            this.btnAddShowFilm.Name = "btnAddShowFilm";
            this.btnAddShowFilm.Size = new System.Drawing.Size(96, 23);
            this.btnAddShowFilm.TabIndex = 55;
            this.btnAddShowFilm.Text = "Добавить";
            this.btnAddShowFilm.UseVisualStyleBackColor = true;
            this.btnAddShowFilm.Click += new System.EventHandler(this.btnAddShowFilm_Click);
            // 
            // dgvwShowFilm
            // 
            this.dgvwShowFilm.AllowUserToAddRows = false;
            this.dgvwShowFilm.AllowUserToDeleteRows = false;
            this.dgvwShowFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwShowFilm.AutoGenerateColumns = false;
            this.dgvwShowFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwShowFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwShowFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзалаDataGridViewTextBoxColumn3,
            this.названиефильмаDataGridViewTextBoxColumn4,
            this.годвыпускаDataGridViewTextBoxColumn4});
            this.dgvwShowFilm.DataSource = this.показываетфильмBindingSource;
            this.dgvwShowFilm.Location = new System.Drawing.Point(235, 19);
            this.dgvwShowFilm.Name = "dgvwShowFilm";
            this.dgvwShowFilm.ReadOnly = true;
            this.dgvwShowFilm.Size = new System.Drawing.Size(379, 405);
            this.dgvwShowFilm.TabIndex = 54;
            this.dgvwShowFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwShowFilm_CellClick);
            // 
            // номерзалаDataGridViewTextBoxColumn3
            // 
            this.номерзалаDataGridViewTextBoxColumn3.DataPropertyName = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn3.HeaderText = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn3.Name = "номерзалаDataGridViewTextBoxColumn3";
            this.номерзалаDataGridViewTextBoxColumn3.ReadOnly = true;
            this.номерзалаDataGridViewTextBoxColumn3.Width = 96;
            // 
            // названиефильмаDataGridViewTextBoxColumn4
            // 
            this.названиефильмаDataGridViewTextBoxColumn4.DataPropertyName = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn4.HeaderText = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn4.Name = "названиефильмаDataGridViewTextBoxColumn4";
            this.названиефильмаDataGridViewTextBoxColumn4.ReadOnly = true;
            this.названиефильмаDataGridViewTextBoxColumn4.Width = 128;
            // 
            // годвыпускаDataGridViewTextBoxColumn4
            // 
            this.годвыпускаDataGridViewTextBoxColumn4.DataPropertyName = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn4.HeaderText = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn4.Name = "годвыпускаDataGridViewTextBoxColumn4";
            this.годвыпускаDataGridViewTextBoxColumn4.ReadOnly = true;
            this.годвыпускаDataGridViewTextBoxColumn4.Width = 99;
            // 
            // показываетфильмBindingSource
            // 
            this.показываетфильмBindingSource.DataMember = "Показывает_фильм";
            this.показываетфильмBindingSource.DataSource = this.showFilmDataSet;
            // 
            // showFilmDataSet
            // 
            this.showFilmDataSet.DataSetName = "ShowFilmDataSet";
            this.showFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNameFilmShowFilm
            // 
            this.txtNameFilmShowFilm.CausesValidation = false;
            this.txtNameFilmShowFilm.Location = new System.Drawing.Point(6, 88);
            this.txtNameFilmShowFilm.Name = "txtNameFilmShowFilm";
            this.txtNameFilmShowFilm.Size = new System.Drawing.Size(207, 20);
            this.txtNameFilmShowFilm.TabIndex = 52;
            this.txtNameFilmShowFilm.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameFilmShowFilm_Validating);
            // 
            // lblNameFilmShowFilm
            // 
            this.lblNameFilmShowFilm.AutoSize = true;
            this.lblNameFilmShowFilm.Location = new System.Drawing.Point(3, 72);
            this.lblNameFilmShowFilm.Name = "lblNameFilmShowFilm";
            this.lblNameFilmShowFilm.Size = new System.Drawing.Size(100, 13);
            this.lblNameFilmShowFilm.TabIndex = 51;
            this.lblNameFilmShowFilm.Text = "Название фильма";
            // 
            // lblYearFilmShowFilm
            // 
            this.lblYearFilmShowFilm.AutoSize = true;
            this.lblYearFilmShowFilm.Location = new System.Drawing.Point(3, 118);
            this.lblYearFilmShowFilm.Name = "lblYearFilmShowFilm";
            this.lblYearFilmShowFilm.Size = new System.Drawing.Size(71, 13);
            this.lblYearFilmShowFilm.TabIndex = 50;
            this.lblYearFilmShowFilm.Text = "Год выпуска";
            // 
            // txtNumHallShowFilm
            // 
            this.txtNumHallShowFilm.CausesValidation = false;
            this.txtNumHallShowFilm.Location = new System.Drawing.Point(6, 42);
            this.txtNumHallShowFilm.Name = "txtNumHallShowFilm";
            this.txtNumHallShowFilm.Size = new System.Drawing.Size(207, 20);
            this.txtNumHallShowFilm.TabIndex = 49;
            this.txtNumHallShowFilm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumHallShowFilm_KeyPress);
            this.txtNumHallShowFilm.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumHallShowFilm_Validating);
            // 
            // lblNumHallShowFilm
            // 
            this.lblNumHallShowFilm.AutoSize = true;
            this.lblNumHallShowFilm.Location = new System.Drawing.Point(3, 23);
            this.lblNumHallShowFilm.Name = "lblNumHallShowFilm";
            this.lblNumHallShowFilm.Size = new System.Drawing.Size(68, 13);
            this.lblNumHallShowFilm.TabIndex = 48;
            this.lblNumHallShowFilm.Text = "Номер зала";
            // 
            // grpPlaceHall
            // 
            this.grpPlaceHall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPlaceHall.Controls.Add(this.grpAddGroupPlaceHall);
            this.grpPlaceHall.Controls.Add(this.grpAddPlaceHall);
            this.grpPlaceHall.Controls.Add(this.dgvwPlaceHall);
            this.grpPlaceHall.Location = new System.Drawing.Point(632, 6);
            this.grpPlaceHall.Name = "grpPlaceHall";
            this.grpPlaceHall.Size = new System.Drawing.Size(546, 619);
            this.grpPlaceHall.TabIndex = 45;
            this.grpPlaceHall.TabStop = false;
            this.grpPlaceHall.Text = "Места в зале";
            // 
            // grpAddGroupPlaceHall
            // 
            this.grpAddGroupPlaceHall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddGroupPlaceHall.Controls.Add(this.txtGroupNumHallPlace);
            this.grpAddGroupPlaceHall.Controls.Add(this.txtGroupQuantityPlaceHall);
            this.grpAddGroupPlaceHall.Controls.Add(this.txtGroupNumRowHallPlace);
            this.grpAddGroupPlaceHall.Controls.Add(this.btnAddGroupPlaceHall);
            this.grpAddGroupPlaceHall.Controls.Add(this.lblGroupQuantityPlaceHall);
            this.grpAddGroupPlaceHall.Controls.Add(this.lblGroupNumRowHallPlace);
            this.grpAddGroupPlaceHall.Controls.Add(this.lblGroupNumHallPlace);
            this.grpAddGroupPlaceHall.Location = new System.Drawing.Point(6, 292);
            this.grpAddGroupPlaceHall.Name = "grpAddGroupPlaceHall";
            this.grpAddGroupPlaceHall.Size = new System.Drawing.Size(283, 321);
            this.grpAddGroupPlaceHall.TabIndex = 5;
            this.grpAddGroupPlaceHall.TabStop = false;
            this.grpAddGroupPlaceHall.Text = "Добавление группы мест в ряд";
            // 
            // txtGroupNumHallPlace
            // 
            this.txtGroupNumHallPlace.CausesValidation = false;
            this.txtGroupNumHallPlace.Location = new System.Drawing.Point(149, 37);
            this.txtGroupNumHallPlace.MaxLength = 3;
            this.txtGroupNumHallPlace.Name = "txtGroupNumHallPlace";
            this.txtGroupNumHallPlace.Size = new System.Drawing.Size(114, 20);
            this.txtGroupNumHallPlace.TabIndex = 7;
            this.txtGroupNumHallPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGroupNumHallPlace_KeyPress);
            this.txtGroupNumHallPlace.Validating += new System.ComponentModel.CancelEventHandler(this.txtGroupNumHallPlace_Validating);
            // 
            // txtGroupQuantityPlaceHall
            // 
            this.txtGroupQuantityPlaceHall.CausesValidation = false;
            this.txtGroupQuantityPlaceHall.Location = new System.Drawing.Point(149, 135);
            this.txtGroupQuantityPlaceHall.MaxLength = 3;
            this.txtGroupQuantityPlaceHall.Name = "txtGroupQuantityPlaceHall";
            this.txtGroupQuantityPlaceHall.Size = new System.Drawing.Size(114, 20);
            this.txtGroupQuantityPlaceHall.TabIndex = 6;
            this.txtGroupQuantityPlaceHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGroupQuantityPlaceHall_KeyPress);
            this.txtGroupQuantityPlaceHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtGroupQuantityPlaceHall_Validating);
            // 
            // txtGroupNumRowHallPlace
            // 
            this.txtGroupNumRowHallPlace.CausesValidation = false;
            this.txtGroupNumRowHallPlace.Location = new System.Drawing.Point(149, 87);
            this.txtGroupNumRowHallPlace.MaxLength = 3;
            this.txtGroupNumRowHallPlace.Name = "txtGroupNumRowHallPlace";
            this.txtGroupNumRowHallPlace.Size = new System.Drawing.Size(114, 20);
            this.txtGroupNumRowHallPlace.TabIndex = 5;
            this.txtGroupNumRowHallPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGroupNumRowHallPlace_KeyPress);
            this.txtGroupNumRowHallPlace.Validating += new System.ComponentModel.CancelEventHandler(this.txtGroupNumRowHallPlace_Validating);
            // 
            // btnAddGroupPlaceHall
            // 
            this.btnAddGroupPlaceHall.Location = new System.Drawing.Point(9, 184);
            this.btnAddGroupPlaceHall.Name = "btnAddGroupPlaceHall";
            this.btnAddGroupPlaceHall.Size = new System.Drawing.Size(268, 23);
            this.btnAddGroupPlaceHall.TabIndex = 3;
            this.btnAddGroupPlaceHall.Text = "Добавить";
            this.btnAddGroupPlaceHall.UseVisualStyleBackColor = true;
            this.btnAddGroupPlaceHall.Click += new System.EventHandler(this.btnAddGroupPlaceHall_Click);
            // 
            // lblGroupQuantityPlaceHall
            // 
            this.lblGroupQuantityPlaceHall.AutoSize = true;
            this.lblGroupQuantityPlaceHall.Location = new System.Drawing.Point(6, 142);
            this.lblGroupQuantityPlaceHall.Name = "lblGroupQuantityPlaceHall";
            this.lblGroupQuantityPlaceHall.Size = new System.Drawing.Size(129, 13);
            this.lblGroupQuantityPlaceHall.TabIndex = 2;
            this.lblGroupQuantityPlaceHall.Text = "Количество мест в ряду";
            // 
            // lblGroupNumRowHallPlace
            // 
            this.lblGroupNumRowHallPlace.AutoSize = true;
            this.lblGroupNumRowHallPlace.Location = new System.Drawing.Point(6, 92);
            this.lblGroupNumRowHallPlace.Name = "lblGroupNumRowHallPlace";
            this.lblGroupNumRowHallPlace.Size = new System.Drawing.Size(68, 13);
            this.lblGroupNumRowHallPlace.TabIndex = 1;
            this.lblGroupNumRowHallPlace.Text = "Номер ряда";
            // 
            // lblGroupNumHallPlace
            // 
            this.lblGroupNumHallPlace.AutoSize = true;
            this.lblGroupNumHallPlace.Location = new System.Drawing.Point(6, 40);
            this.lblGroupNumHallPlace.Name = "lblGroupNumHallPlace";
            this.lblGroupNumHallPlace.Size = new System.Drawing.Size(68, 13);
            this.lblGroupNumHallPlace.TabIndex = 0;
            this.lblGroupNumHallPlace.Text = "Номер зала";
            // 
            // grpAddPlaceHall
            // 
            this.grpAddPlaceHall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddPlaceHall.Controls.Add(this.txtNumHallPlaceHall);
            this.grpAddPlaceHall.Controls.Add(this.btnDeletePlaceHall);
            this.grpAddPlaceHall.Controls.Add(this.txtNumPlaceHall);
            this.grpAddPlaceHall.Controls.Add(this.txtNumRowPlaceHall);
            this.grpAddPlaceHall.Controls.Add(this.btnAddPlaceHall);
            this.grpAddPlaceHall.Controls.Add(this.lblNumPlaceHall);
            this.grpAddPlaceHall.Controls.Add(this.lblNumRowPlaceHall);
            this.grpAddPlaceHall.Controls.Add(this.lblNumHallPlaceHall);
            this.grpAddPlaceHall.Location = new System.Drawing.Point(6, 19);
            this.grpAddPlaceHall.Name = "grpAddPlaceHall";
            this.grpAddPlaceHall.Size = new System.Drawing.Size(283, 267);
            this.grpAddPlaceHall.TabIndex = 4;
            this.grpAddPlaceHall.TabStop = false;
            this.grpAddPlaceHall.Text = "Добавление места";
            // 
            // txtNumHallPlaceHall
            // 
            this.txtNumHallPlaceHall.CausesValidation = false;
            this.txtNumHallPlaceHall.Location = new System.Drawing.Point(141, 32);
            this.txtNumHallPlaceHall.MaxLength = 3;
            this.txtNumHallPlaceHall.Name = "txtNumHallPlaceHall";
            this.txtNumHallPlaceHall.Size = new System.Drawing.Size(122, 20);
            this.txtNumHallPlaceHall.TabIndex = 16;
            this.txtNumHallPlaceHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumHallPlaceHall_KeyPress);
            this.txtNumHallPlaceHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumHallPlaceHall_Validating);
            // 
            // btnDeletePlaceHall
            // 
            this.btnDeletePlaceHall.Location = new System.Drawing.Point(141, 176);
            this.btnDeletePlaceHall.Name = "btnDeletePlaceHall";
            this.btnDeletePlaceHall.Size = new System.Drawing.Size(122, 23);
            this.btnDeletePlaceHall.TabIndex = 15;
            this.btnDeletePlaceHall.Text = "Удалить";
            this.btnDeletePlaceHall.UseVisualStyleBackColor = true;
            this.btnDeletePlaceHall.Click += new System.EventHandler(this.btnDeletePlaceHall_Click);
            // 
            // txtNumPlaceHall
            // 
            this.txtNumPlaceHall.CausesValidation = false;
            this.txtNumPlaceHall.Location = new System.Drawing.Point(141, 124);
            this.txtNumPlaceHall.MaxLength = 3;
            this.txtNumPlaceHall.Name = "txtNumPlaceHall";
            this.txtNumPlaceHall.Size = new System.Drawing.Size(122, 20);
            this.txtNumPlaceHall.TabIndex = 13;
            this.txtNumPlaceHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPlaceHall_KeyPress);
            this.txtNumPlaceHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumPlaceHall_Validating);
            // 
            // txtNumRowPlaceHall
            // 
            this.txtNumRowPlaceHall.CausesValidation = false;
            this.txtNumRowPlaceHall.Location = new System.Drawing.Point(141, 77);
            this.txtNumRowPlaceHall.MaxLength = 3;
            this.txtNumRowPlaceHall.Name = "txtNumRowPlaceHall";
            this.txtNumRowPlaceHall.Size = new System.Drawing.Size(122, 20);
            this.txtNumRowPlaceHall.TabIndex = 12;
            this.txtNumRowPlaceHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRowPlaceHall_KeyPress);
            this.txtNumRowPlaceHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumRowPlaceHall_Validating);
            // 
            // btnAddPlaceHall
            // 
            this.btnAddPlaceHall.Location = new System.Drawing.Point(6, 176);
            this.btnAddPlaceHall.Name = "btnAddPlaceHall";
            this.btnAddPlaceHall.Size = new System.Drawing.Size(121, 23);
            this.btnAddPlaceHall.TabIndex = 10;
            this.btnAddPlaceHall.Text = "Добавить";
            this.btnAddPlaceHall.UseVisualStyleBackColor = true;
            this.btnAddPlaceHall.Click += new System.EventHandler(this.btnAddPlaceHall_Click);
            // 
            // lblNumPlaceHall
            // 
            this.lblNumPlaceHall.AutoSize = true;
            this.lblNumPlaceHall.Location = new System.Drawing.Point(6, 131);
            this.lblNumPlaceHall.Name = "lblNumPlaceHall";
            this.lblNumPlaceHall.Size = new System.Drawing.Size(75, 13);
            this.lblNumPlaceHall.TabIndex = 9;
            this.lblNumPlaceHall.Text = "Номер места";
            // 
            // lblNumRowPlaceHall
            // 
            this.lblNumRowPlaceHall.AutoSize = true;
            this.lblNumRowPlaceHall.Location = new System.Drawing.Point(6, 84);
            this.lblNumRowPlaceHall.Name = "lblNumRowPlaceHall";
            this.lblNumRowPlaceHall.Size = new System.Drawing.Size(68, 13);
            this.lblNumRowPlaceHall.TabIndex = 8;
            this.lblNumRowPlaceHall.Text = "Номер ряда";
            // 
            // lblNumHallPlaceHall
            // 
            this.lblNumHallPlaceHall.AutoSize = true;
            this.lblNumHallPlaceHall.Location = new System.Drawing.Point(6, 35);
            this.lblNumHallPlaceHall.Name = "lblNumHallPlaceHall";
            this.lblNumHallPlaceHall.Size = new System.Drawing.Size(68, 13);
            this.lblNumHallPlaceHall.TabIndex = 7;
            this.lblNumHallPlaceHall.Text = "Номер зала";
            // 
            // dgvwPlaceHall
            // 
            this.dgvwPlaceHall.AllowUserToAddRows = false;
            this.dgvwPlaceHall.AllowUserToDeleteRows = false;
            this.dgvwPlaceHall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwPlaceHall.AutoGenerateColumns = false;
            this.dgvwPlaceHall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwPlaceHall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwPlaceHall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерместаDataGridViewTextBoxColumn,
            this.номеррядаDataGridViewTextBoxColumn,
            this.номерзалаDataGridViewTextBoxColumn1});
            this.dgvwPlaceHall.DataSource = this.меставзалеBindingSource;
            this.dgvwPlaceHall.Location = new System.Drawing.Point(295, 19);
            this.dgvwPlaceHall.Name = "dgvwPlaceHall";
            this.dgvwPlaceHall.ReadOnly = true;
            this.dgvwPlaceHall.Size = new System.Drawing.Size(245, 594);
            this.dgvwPlaceHall.TabIndex = 3;
            this.dgvwPlaceHall.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwPlaceHall_CellClick);
            // 
            // номерместаDataGridViewTextBoxColumn
            // 
            this.номерместаDataGridViewTextBoxColumn.DataPropertyName = "Номер_места";
            this.номерместаDataGridViewTextBoxColumn.HeaderText = "Место";
            this.номерместаDataGridViewTextBoxColumn.Name = "номерместаDataGridViewTextBoxColumn";
            this.номерместаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерместаDataGridViewTextBoxColumn.Width = 64;
            // 
            // номеррядаDataGridViewTextBoxColumn
            // 
            this.номеррядаDataGridViewTextBoxColumn.DataPropertyName = "Номер_ряда";
            this.номеррядаDataGridViewTextBoxColumn.HeaderText = "Ряд";
            this.номеррядаDataGridViewTextBoxColumn.Name = "номеррядаDataGridViewTextBoxColumn";
            this.номеррядаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номеррядаDataGridViewTextBoxColumn.Width = 51;
            // 
            // номерзалаDataGridViewTextBoxColumn1
            // 
            this.номерзалаDataGridViewTextBoxColumn1.DataPropertyName = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn1.HeaderText = "Зал";
            this.номерзалаDataGridViewTextBoxColumn1.Name = "номерзалаDataGridViewTextBoxColumn1";
            this.номерзалаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.номерзалаDataGridViewTextBoxColumn1.Width = 51;
            // 
            // меставзалеBindingSource
            // 
            this.меставзалеBindingSource.DataMember = "Места_в_зале";
            this.меставзалеBindingSource.DataSource = this.placeInHallDataSet;
            // 
            // placeInHallDataSet
            // 
            this.placeInHallDataSet.DataSetName = "PlaceInHallDataSet";
            this.placeInHallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpHall
            // 
            this.grpHall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHall.Controls.Add(this.txtDescriptionHall);
            this.grpHall.Controls.Add(this.txtQuantityPlaceHall);
            this.grpHall.Controls.Add(this.txtNumHall);
            this.grpHall.Controls.Add(this.btnUpdateHall);
            this.grpHall.Controls.Add(this.btnDeleteHall);
            this.grpHall.Controls.Add(this.btnAddHall);
            this.grpHall.Controls.Add(this.lblQuantityPlaceHall);
            this.grpHall.Controls.Add(this.lblDescriptionHall);
            this.grpHall.Controls.Add(this.lblNumHall);
            this.grpHall.Controls.Add(this.dgvwHall);
            this.grpHall.Location = new System.Drawing.Point(6, 6);
            this.grpHall.Name = "grpHall";
            this.grpHall.Size = new System.Drawing.Size(620, 189);
            this.grpHall.TabIndex = 43;
            this.grpHall.TabStop = false;
            this.grpHall.Text = "Зал";
            // 
            // txtDescriptionHall
            // 
            this.txtDescriptionHall.CausesValidation = false;
            this.txtDescriptionHall.Location = new System.Drawing.Point(6, 74);
            this.txtDescriptionHall.MaxLength = 50;
            this.txtDescriptionHall.Name = "txtDescriptionHall";
            this.txtDescriptionHall.Size = new System.Drawing.Size(207, 20);
            this.txtDescriptionHall.TabIndex = 52;
            this.txtDescriptionHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescriptionHall_Validating);
            // 
            // txtQuantityPlaceHall
            // 
            this.txtQuantityPlaceHall.CausesValidation = false;
            this.txtQuantityPlaceHall.Location = new System.Drawing.Point(6, 115);
            this.txtQuantityPlaceHall.MaxLength = 6;
            this.txtQuantityPlaceHall.Name = "txtQuantityPlaceHall";
            this.txtQuantityPlaceHall.Size = new System.Drawing.Size(207, 20);
            this.txtQuantityPlaceHall.TabIndex = 50;
            this.txtQuantityPlaceHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityPlaceHall_KeyPress);
            this.txtQuantityPlaceHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantityPlaceHall_Validating);
            // 
            // txtNumHall
            // 
            this.txtNumHall.CausesValidation = false;
            this.txtNumHall.Location = new System.Drawing.Point(6, 35);
            this.txtNumHall.MaxLength = 3;
            this.txtNumHall.Name = "txtNumHall";
            this.txtNumHall.Size = new System.Drawing.Size(207, 20);
            this.txtNumHall.TabIndex = 45;
            this.txtNumHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumHall_KeyPress);
            this.txtNumHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumHall_Validating);
            // 
            // btnUpdateHall
            // 
            this.btnUpdateHall.Location = new System.Drawing.Point(77, 150);
            this.btnUpdateHall.Name = "btnUpdateHall";
            this.btnUpdateHall.Size = new System.Drawing.Size(65, 23);
            this.btnUpdateHall.TabIndex = 51;
            this.btnUpdateHall.Text = "Обновить";
            this.btnUpdateHall.UseVisualStyleBackColor = true;
            this.btnUpdateHall.Click += new System.EventHandler(this.btnUpdateHall_Click);
            // 
            // btnDeleteHall
            // 
            this.btnDeleteHall.Location = new System.Drawing.Point(147, 150);
            this.btnDeleteHall.Name = "btnDeleteHall";
            this.btnDeleteHall.Size = new System.Drawing.Size(65, 23);
            this.btnDeleteHall.TabIndex = 49;
            this.btnDeleteHall.Text = "Удалить";
            this.btnDeleteHall.UseVisualStyleBackColor = true;
            this.btnDeleteHall.Click += new System.EventHandler(this.btnDeleteHall_Click);
            // 
            // btnAddHall
            // 
            this.btnAddHall.Location = new System.Drawing.Point(5, 150);
            this.btnAddHall.Name = "btnAddHall";
            this.btnAddHall.Size = new System.Drawing.Size(65, 23);
            this.btnAddHall.TabIndex = 48;
            this.btnAddHall.Text = "Добавить";
            this.btnAddHall.UseVisualStyleBackColor = true;
            this.btnAddHall.Click += new System.EventHandler(this.btnAddHall_Click);
            // 
            // lblQuantityPlaceHall
            // 
            this.lblQuantityPlaceHall.AutoSize = true;
            this.lblQuantityPlaceHall.Location = new System.Drawing.Point(3, 99);
            this.lblQuantityPlaceHall.Name = "lblQuantityPlaceHall";
            this.lblQuantityPlaceHall.Size = new System.Drawing.Size(94, 13);
            this.lblQuantityPlaceHall.TabIndex = 47;
            this.lblQuantityPlaceHall.Text = "Количество мест";
            // 
            // lblDescriptionHall
            // 
            this.lblDescriptionHall.AutoSize = true;
            this.lblDescriptionHall.Location = new System.Drawing.Point(3, 58);
            this.lblDescriptionHall.Name = "lblDescriptionHall";
            this.lblDescriptionHall.Size = new System.Drawing.Size(84, 13);
            this.lblDescriptionHall.TabIndex = 46;
            this.lblDescriptionHall.Text = "Описание зала";
            // 
            // lblNumHall
            // 
            this.lblNumHall.AutoSize = true;
            this.lblNumHall.Location = new System.Drawing.Point(3, 19);
            this.lblNumHall.Name = "lblNumHall";
            this.lblNumHall.Size = new System.Drawing.Size(68, 13);
            this.lblNumHall.TabIndex = 44;
            this.lblNumHall.Text = "Номер зала";
            // 
            // dgvwHall
            // 
            this.dgvwHall.AllowUserToAddRows = false;
            this.dgvwHall.AllowUserToDeleteRows = false;
            this.dgvwHall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwHall.AutoGenerateColumns = false;
            this.dgvwHall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwHall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwHall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзалаDataGridViewTextBoxColumn,
            this.описаниезалаDataGridViewTextBoxColumn,
            this.количествоместDataGridViewTextBoxColumn});
            this.dgvwHall.DataSource = this.залBindingSource;
            this.dgvwHall.Location = new System.Drawing.Point(235, 19);
            this.dgvwHall.Name = "dgvwHall";
            this.dgvwHall.ReadOnly = true;
            this.dgvwHall.Size = new System.Drawing.Size(379, 164);
            this.dgvwHall.TabIndex = 43;
            this.dgvwHall.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwHall_CellClick);
            // 
            // номерзалаDataGridViewTextBoxColumn
            // 
            this.номерзалаDataGridViewTextBoxColumn.DataPropertyName = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn.HeaderText = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn.Name = "номерзалаDataGridViewTextBoxColumn";
            this.номерзалаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерзалаDataGridViewTextBoxColumn.Width = 96;
            // 
            // описаниезалаDataGridViewTextBoxColumn
            // 
            this.описаниезалаDataGridViewTextBoxColumn.DataPropertyName = "Описание_зала";
            this.описаниезалаDataGridViewTextBoxColumn.HeaderText = "Описание_зала";
            this.описаниезалаDataGridViewTextBoxColumn.Name = "описаниезалаDataGridViewTextBoxColumn";
            this.описаниезалаDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниезалаDataGridViewTextBoxColumn.Width = 112;
            // 
            // количествоместDataGridViewTextBoxColumn
            // 
            this.количествоместDataGridViewTextBoxColumn.DataPropertyName = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.HeaderText = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn.Name = "количествоместDataGridViewTextBoxColumn";
            this.количествоместDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоместDataGridViewTextBoxColumn.Width = 122;
            // 
            // залBindingSource
            // 
            this.залBindingSource.DataMember = "Зал";
            this.залBindingSource.DataSource = this.hallDataSet;
            // 
            // hallDataSet
            // 
            this.hallDataSet.DataSetName = "HallDataSet";
            this.hallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.reportViewer6);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(1184, 631);
            this.tabPage15.TabIndex = 3;
            this.tabPage15.Text = "Отчет о фильмах";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource85.Name = "TopFilm";
            reportDataSource85.Value = this.Топ_фильмовBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource85);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "Cinema.TopFilm.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(3, 3);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(1178, 625);
            this.reportViewer6.TabIndex = 0;
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.reportViewer5);
            this.tabPage16.Location = new System.Drawing.Point(4, 22);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(1184, 631);
            this.tabPage16.TabIndex = 4;
            this.tabPage16.Text = "Отчет о пустых залах";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource86.Name = "FreeHall";
            reportDataSource86.Value = this.Залы_без_фильмовBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource86);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Cinema.FreeHall.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(1178, 625);
            this.reportViewer5.TabIndex = 0;
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.reportViewer4);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(1184, 631);
            this.tabPage17.TabIndex = 5;
            this.tabPage17.Text = "Отчет о залах";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource87.Name = "CountOfTickets";
            reportDataSource87.Value = this.Кол_билетов_залаBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource87);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Cinema.CountOfTickets.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1178, 625);
            this.reportViewer4.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabCashier);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1198, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Кассир";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabCashier
            // 
            this.tabCashier.Controls.Add(this.tabPage6);
            this.tabCashier.Controls.Add(this.tabPage7);
            this.tabCashier.Controls.Add(this.tabPage14);
            this.tabCashier.Controls.Add(this.tabReportTicket);
            this.tabCashier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCashier.Location = new System.Drawing.Point(3, 3);
            this.tabCashier.Name = "tabCashier";
            this.tabCashier.SelectedIndex = 0;
            this.tabCashier.Size = new System.Drawing.Size(1192, 657);
            this.tabCashier.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtmPhone);
            this.tabPage6.Controls.Add(this.dgvwClient);
            this.tabPage6.Controls.Add(this.cboTypeClient);
            this.tabPage6.Controls.Add(this.txtEmail);
            this.tabPage6.Controls.Add(this.txtDiscountCard);
            this.tabPage6.Controls.Add(this.txtFullName);
            this.tabPage6.Controls.Add(this.lblPhone);
            this.tabPage6.Controls.Add(this.lblEmail);
            this.tabPage6.Controls.Add(this.lblDiscountCard);
            this.tabPage6.Controls.Add(this.lblTypeClient);
            this.tabPage6.Controls.Add(this.lblFullName);
            this.tabPage6.Controls.Add(this.btnDeleteClient);
            this.tabPage6.Controls.Add(this.btnUpdateClient);
            this.tabPage6.Controls.Add(this.btnAddClient);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1184, 631);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Клиенты";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtmPhone
            // 
            this.txtmPhone.BeepOnError = true;
            this.txtmPhone.CausesValidation = false;
            this.txtmPhone.Location = new System.Drawing.Point(11, 267);
            this.txtmPhone.Mask = "+70000000000";
            this.txtmPhone.Name = "txtmPhone";
            this.txtmPhone.ResetOnSpace = false;
            this.txtmPhone.Size = new System.Drawing.Size(234, 20);
            this.txtmPhone.TabIndex = 17;
            this.txtmPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmPhone_MouseClick);
            this.txtmPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmPhone_KeyDown);
            this.txtmPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtmPhone_Validating);
            // 
            // dgvwClient
            // 
            this.dgvwClient.AllowUserToAddRows = false;
            this.dgvwClient.AllowUserToDeleteRows = false;
            this.dgvwClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwClient.AutoGenerateColumns = false;
            this.dgvwClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОклиентаDataGridViewTextBoxColumn,
            this.типклиентаDataGridViewTextBoxColumn,
            this.скидочнаякартаDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.телефонклиентаDataGridViewTextBoxColumn});
            this.dgvwClient.DataSource = this.клиентBindingSource;
            this.dgvwClient.Location = new System.Drawing.Point(268, 6);
            this.dgvwClient.Name = "dgvwClient";
            this.dgvwClient.ReadOnly = true;
            this.dgvwClient.Size = new System.Drawing.Size(910, 619);
            this.dgvwClient.TabIndex = 16;
            this.dgvwClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwClient_CellClick);
            // 
            // фИОклиентаDataGridViewTextBoxColumn
            // 
            this.фИОклиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО_клиента";
            this.фИОклиентаDataGridViewTextBoxColumn.HeaderText = "ФИО_клиента";
            this.фИОклиентаDataGridViewTextBoxColumn.Name = "фИОклиентаDataGridViewTextBoxColumn";
            this.фИОклиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОклиентаDataGridViewTextBoxColumn.Width = 106;
            // 
            // типклиентаDataGridViewTextBoxColumn
            // 
            this.типклиентаDataGridViewTextBoxColumn.DataPropertyName = "Тип_клиента";
            this.типклиентаDataGridViewTextBoxColumn.HeaderText = "Тип_клиента";
            this.типклиентаDataGridViewTextBoxColumn.Name = "типклиентаDataGridViewTextBoxColumn";
            this.типклиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.типклиентаDataGridViewTextBoxColumn.Width = 98;
            // 
            // скидочнаякартаDataGridViewTextBoxColumn
            // 
            this.скидочнаякартаDataGridViewTextBoxColumn.DataPropertyName = "Скидочная_карта";
            this.скидочнаякартаDataGridViewTextBoxColumn.HeaderText = "Скидочная_карта";
            this.скидочнаякартаDataGridViewTextBoxColumn.Name = "скидочнаякартаDataGridViewTextBoxColumn";
            this.скидочнаякартаDataGridViewTextBoxColumn.ReadOnly = true;
            this.скидочнаякартаDataGridViewTextBoxColumn.Width = 121;
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            this.скидкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.скидкаDataGridViewTextBoxColumn.Width = 69;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // телефонклиентаDataGridViewTextBoxColumn
            // 
            this.телефонклиентаDataGridViewTextBoxColumn.DataPropertyName = "Телефон_клиента";
            this.телефонклиентаDataGridViewTextBoxColumn.HeaderText = "Телефон_клиента";
            this.телефонклиентаDataGridViewTextBoxColumn.Name = "телефонклиентаDataGridViewTextBoxColumn";
            this.телефонклиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.телефонклиентаDataGridViewTextBoxColumn.Width = 124;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.clientDataSet;
            // 
            // clientDataSet
            // 
            this.clientDataSet.DataSetName = "ClientDataSet";
            this.clientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboTypeClient
            // 
            this.cboTypeClient.CausesValidation = false;
            this.cboTypeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeClient.FormattingEnabled = true;
            this.cboTypeClient.Items.AddRange(new object[] {
            "Обычный",
            "VIP"});
            this.cboTypeClient.Location = new System.Drawing.Point(9, 81);
            this.cboTypeClient.Name = "cboTypeClient";
            this.cboTypeClient.Size = new System.Drawing.Size(236, 21);
            this.cboTypeClient.TabIndex = 15;
            this.cboTypeClient.Validating += new System.ComponentModel.CancelEventHandler(this.cboTypeClient_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.CausesValidation = false;
            this.txtEmail.Location = new System.Drawing.Point(9, 201);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 20);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "NoEmailClient@cinema.ru";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtDiscountCard
            // 
            this.txtDiscountCard.CausesValidation = false;
            this.txtDiscountCard.Location = new System.Drawing.Point(9, 142);
            this.txtDiscountCard.MaxLength = 8;
            this.txtDiscountCard.Name = "txtDiscountCard";
            this.txtDiscountCard.Size = new System.Drawing.Size(236, 20);
            this.txtDiscountCard.TabIndex = 11;
            this.txtDiscountCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountCard_KeyPress);
            this.txtDiscountCard.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiscountCard_Validating);
            // 
            // txtFullName
            // 
            this.txtFullName.CausesValidation = false;
            this.txtFullName.Location = new System.Drawing.Point(9, 25);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(236, 20);
            this.txtFullName.TabIndex = 9;
            this.txtFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFullName_Validating);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(8, 245);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Телефон";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblDiscountCard
            // 
            this.lblDiscountCard.AutoSize = true;
            this.lblDiscountCard.Location = new System.Drawing.Point(8, 126);
            this.lblDiscountCard.Name = "lblDiscountCard";
            this.lblDiscountCard.Size = new System.Drawing.Size(93, 13);
            this.lblDiscountCard.TabIndex = 6;
            this.lblDiscountCard.Text = "Скидочная карта";
            // 
            // lblTypeClient
            // 
            this.lblTypeClient.AutoSize = true;
            this.lblTypeClient.Location = new System.Drawing.Point(8, 65);
            this.lblTypeClient.Name = "lblTypeClient";
            this.lblTypeClient.Size = new System.Drawing.Size(70, 13);
            this.lblTypeClient.TabIndex = 5;
            this.lblTypeClient.Text = "Тип клиента";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(6, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(34, 13);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "ФИО";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(173, 303);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(72, 23);
            this.btnDeleteClient.TabIndex = 2;
            this.btnDeleteClient.Text = "Удалить";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(92, 303);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateClient.TabIndex = 1;
            this.btnUpdateClient.Text = "Обновить";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(9, 303);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(77, 23);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Добавить";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.grpTicketPrint);
            this.tabPage7.Controls.Add(this.grpSoldTickets);
            this.tabPage7.Controls.Add(this.grpSellTicket);
            this.tabPage7.Controls.Add(this.grpTicket);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1184, 631);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Билеты";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // grpTicketPrint
            // 
            this.grpTicketPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTicketPrint.Controls.Add(this.btnPrint);
            this.grpTicketPrint.Controls.Add(this.picTicket);
            this.grpTicketPrint.Location = new System.Drawing.Point(704, 454);
            this.grpTicketPrint.Name = "grpTicketPrint";
            this.grpTicketPrint.Size = new System.Drawing.Size(468, 165);
            this.grpTicketPrint.TabIndex = 72;
            this.grpTicketPrint.TabStop = false;
            this.grpTicketPrint.Text = "Билет";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(301, 136);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(161, 23);
            this.btnPrint.TabIndex = 72;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // picTicket
            // 
            this.picTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picTicket.Image = global::Cinema.Properties.Resources.ticket;
            this.picTicket.Location = new System.Drawing.Point(6, 19);
            this.picTicket.Name = "picTicket";
            this.picTicket.Size = new System.Drawing.Size(289, 140);
            this.picTicket.TabIndex = 71;
            this.picTicket.TabStop = false;
            // 
            // grpSoldTickets
            // 
            this.grpSoldTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSoldTickets.Controls.Add(this.dgvwSoldTickets);
            this.grpSoldTickets.Location = new System.Drawing.Point(704, 216);
            this.grpSoldTickets.Name = "grpSoldTickets";
            this.grpSoldTickets.Size = new System.Drawing.Size(471, 232);
            this.grpSoldTickets.TabIndex = 2;
            this.grpSoldTickets.TabStop = false;
            this.grpSoldTickets.Text = "Проданные билеты";
            // 
            // dgvwSoldTickets
            // 
            this.dgvwSoldTickets.AllowUserToAddRows = false;
            this.dgvwSoldTickets.AllowUserToDeleteRows = false;
            this.dgvwSoldTickets.AutoGenerateColumns = false;
            this.dgvwSoldTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwSoldTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwSoldTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиефильмаDataGridViewTextBoxColumn6,
            this.годвыпускаDataGridViewTextBoxColumn5,
            this.номерместаDataGridViewTextBoxColumn1,
            this.номеррядаDataGridViewTextBoxColumn1,
            this.номерзалаDataGridViewTextBoxColumn7,
            this.фИОклиентаDataGridViewTextBoxColumn2,
            this.времясеансаDataGridViewTextBoxColumn1,
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn4,
            this.фИОсотрудникаDataGridViewTextBoxColumn5,
            this.номербилетаDataGridViewTextBoxColumn1,
            this.телефонклиентаDataGridViewTextBoxColumn1});
            this.dgvwSoldTickets.DataSource = this.продажабилетовBindingSource;
            this.dgvwSoldTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwSoldTickets.Location = new System.Drawing.Point(3, 16);
            this.dgvwSoldTickets.Name = "dgvwSoldTickets";
            this.dgvwSoldTickets.ReadOnly = true;
            this.dgvwSoldTickets.Size = new System.Drawing.Size(465, 213);
            this.dgvwSoldTickets.TabIndex = 0;
            // 
            // названиефильмаDataGridViewTextBoxColumn6
            // 
            this.названиефильмаDataGridViewTextBoxColumn6.DataPropertyName = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn6.HeaderText = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn6.Name = "названиефильмаDataGridViewTextBoxColumn6";
            this.названиефильмаDataGridViewTextBoxColumn6.ReadOnly = true;
            this.названиефильмаDataGridViewTextBoxColumn6.Width = 128;
            // 
            // годвыпускаDataGridViewTextBoxColumn5
            // 
            this.годвыпускаDataGridViewTextBoxColumn5.DataPropertyName = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn5.HeaderText = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn5.Name = "годвыпускаDataGridViewTextBoxColumn5";
            this.годвыпускаDataGridViewTextBoxColumn5.ReadOnly = true;
            this.годвыпускаDataGridViewTextBoxColumn5.Width = 99;
            // 
            // номерместаDataGridViewTextBoxColumn1
            // 
            this.номерместаDataGridViewTextBoxColumn1.DataPropertyName = "Номер_места";
            this.номерместаDataGridViewTextBoxColumn1.HeaderText = "Номер_места";
            this.номерместаDataGridViewTextBoxColumn1.Name = "номерместаDataGridViewTextBoxColumn1";
            this.номерместаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.номерместаDataGridViewTextBoxColumn1.Width = 103;
            // 
            // номеррядаDataGridViewTextBoxColumn1
            // 
            this.номеррядаDataGridViewTextBoxColumn1.DataPropertyName = "Номер_ряда";
            this.номеррядаDataGridViewTextBoxColumn1.HeaderText = "Номер_ряда";
            this.номеррядаDataGridViewTextBoxColumn1.Name = "номеррядаDataGridViewTextBoxColumn1";
            this.номеррядаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.номеррядаDataGridViewTextBoxColumn1.Width = 96;
            // 
            // номерзалаDataGridViewTextBoxColumn7
            // 
            this.номерзалаDataGridViewTextBoxColumn7.DataPropertyName = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn7.HeaderText = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn7.Name = "номерзалаDataGridViewTextBoxColumn7";
            this.номерзалаDataGridViewTextBoxColumn7.ReadOnly = true;
            this.номерзалаDataGridViewTextBoxColumn7.Width = 96;
            // 
            // фИОклиентаDataGridViewTextBoxColumn2
            // 
            this.фИОклиентаDataGridViewTextBoxColumn2.DataPropertyName = "ФИО_клиента";
            this.фИОклиентаDataGridViewTextBoxColumn2.HeaderText = "ФИО_клиента";
            this.фИОклиентаDataGridViewTextBoxColumn2.Name = "фИОклиентаDataGridViewTextBoxColumn2";
            this.фИОклиентаDataGridViewTextBoxColumn2.ReadOnly = true;
            this.фИОклиентаDataGridViewTextBoxColumn2.Width = 106;
            // 
            // времясеансаDataGridViewTextBoxColumn1
            // 
            this.времясеансаDataGridViewTextBoxColumn1.DataPropertyName = "Время_сеанса";
            this.времясеансаDataGridViewTextBoxColumn1.HeaderText = "Время_сеанса";
            this.времясеансаDataGridViewTextBoxColumn1.Name = "времясеансаDataGridViewTextBoxColumn1";
            this.времясеансаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.времясеансаDataGridViewTextBoxColumn1.Width = 107;
            // 
            // паспортныеданныесотрудникаDataGridViewTextBoxColumn4
            // 
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn4.DataPropertyName = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn4.HeaderText = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn4.Name = "паспортныеданныесотрудникаDataGridViewTextBoxColumn4";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn4.ReadOnly = true;
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn4.Width = 203;
            // 
            // фИОсотрудникаDataGridViewTextBoxColumn5
            // 
            this.фИОсотрудникаDataGridViewTextBoxColumn5.DataPropertyName = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn5.HeaderText = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn5.Name = "фИОсотрудникаDataGridViewTextBoxColumn5";
            this.фИОсотрудникаDataGridViewTextBoxColumn5.ReadOnly = true;
            this.фИОсотрудникаDataGridViewTextBoxColumn5.Width = 123;
            // 
            // номербилетаDataGridViewTextBoxColumn1
            // 
            this.номербилетаDataGridViewTextBoxColumn1.DataPropertyName = "Номер_билета";
            this.номербилетаDataGridViewTextBoxColumn1.HeaderText = "Номер_билета";
            this.номербилетаDataGridViewTextBoxColumn1.Name = "номербилетаDataGridViewTextBoxColumn1";
            this.номербилетаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.номербилетаDataGridViewTextBoxColumn1.Width = 107;
            // 
            // телефонклиентаDataGridViewTextBoxColumn1
            // 
            this.телефонклиентаDataGridViewTextBoxColumn1.DataPropertyName = "Телефон_клиента";
            this.телефонклиентаDataGridViewTextBoxColumn1.HeaderText = "Телефон_клиента";
            this.телефонклиентаDataGridViewTextBoxColumn1.Name = "телефонклиентаDataGridViewTextBoxColumn1";
            this.телефонклиентаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.телефонклиентаDataGridViewTextBoxColumn1.Width = 124;
            // 
            // продажабилетовBindingSource
            // 
            this.продажабилетовBindingSource.DataMember = "Продажа_билетов";
            this.продажабилетовBindingSource.DataSource = this.soldTicketsDataSet;
            // 
            // grpSellTicket
            // 
            this.grpSellTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpSellTicket.Controls.Add(this.lblYearFilmTicket);
            this.grpSellTicket.Controls.Add(this.cboYearFilmTicket);
            this.grpSellTicket.Controls.Add(this.grpHallLayout);
            this.grpSellTicket.Controls.Add(this.grpSellTicketPlace);
            this.grpSellTicket.Controls.Add(this.cboNumHallTicket);
            this.grpSellTicket.Controls.Add(this.lblNumHallTicket);
            this.grpSellTicket.Controls.Add(this.btnShowFilmTicket);
            this.grpSellTicket.Controls.Add(this.cboDateSessionTicket);
            this.grpSellTicket.Controls.Add(this.cboNameFilmTicket);
            this.grpSellTicket.Controls.Add(this.lblDateSessionTicket);
            this.grpSellTicket.Controls.Add(this.lblNameFilmTicket);
            this.grpSellTicket.Location = new System.Drawing.Point(6, 6);
            this.grpSellTicket.Name = "grpSellTicket";
            this.grpSellTicket.Size = new System.Drawing.Size(692, 619);
            this.grpSellTicket.TabIndex = 1;
            this.grpSellTicket.TabStop = false;
            this.grpSellTicket.Text = "Продажа билетов";
            // 
            // lblYearFilmTicket
            // 
            this.lblYearFilmTicket.AutoSize = true;
            this.lblYearFilmTicket.Location = new System.Drawing.Point(7, 58);
            this.lblYearFilmTicket.Name = "lblYearFilmTicket";
            this.lblYearFilmTicket.Size = new System.Drawing.Size(71, 13);
            this.lblYearFilmTicket.TabIndex = 69;
            this.lblYearFilmTicket.Text = "Год выпуска";
            // 
            // cboYearFilmTicket
            // 
            this.cboYearFilmTicket.DisplayMember = "Название_фильма";
            this.cboYearFilmTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYearFilmTicket.FormattingEnabled = true;
            this.cboYearFilmTicket.Location = new System.Drawing.Point(129, 50);
            this.cboYearFilmTicket.Name = "cboYearFilmTicket";
            this.cboYearFilmTicket.Size = new System.Drawing.Size(237, 21);
            this.cboYearFilmTicket.TabIndex = 68;
            this.cboYearFilmTicket.ValueMember = "Название_фильма";
            this.cboYearFilmTicket.SelectionChangeCommitted += new System.EventHandler(this.cboYearFilmTicket_SelectionChangeCommitted);
            // 
            // grpHallLayout
            // 
            this.grpHallLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHallLayout.Controls.Add(this.dgvwHallTicket);
            this.grpHallLayout.Location = new System.Drawing.Point(216, 173);
            this.grpHallLayout.Name = "grpHallLayout";
            this.grpHallLayout.Size = new System.Drawing.Size(469, 440);
            this.grpHallLayout.TabIndex = 67;
            this.grpHallLayout.TabStop = false;
            this.grpHallLayout.Text = "Схема зала";
            // 
            // dgvwHallTicket
            // 
            this.dgvwHallTicket.AllowUserToAddRows = false;
            this.dgvwHallTicket.AllowUserToDeleteRows = false;
            this.dgvwHallTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwHallTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvwHallTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwHallTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwHallTicket.Location = new System.Drawing.Point(3, 16);
            this.dgvwHallTicket.MultiSelect = false;
            this.dgvwHallTicket.Name = "dgvwHallTicket";
            this.dgvwHallTicket.ReadOnly = true;
            this.dgvwHallTicket.RowHeadersVisible = false;
            this.dgvwHallTicket.Size = new System.Drawing.Size(463, 421);
            this.dgvwHallTicket.TabIndex = 9;
            this.dgvwHallTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwHallTicket_CellClick);
            // 
            // grpSellTicketPlace
            // 
            this.grpSellTicketPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSellTicketPlace.Controls.Add(this.lblNumRowTicket);
            this.grpSellTicketPlace.Controls.Add(this.lblNumPlaceTicket);
            this.grpSellTicketPlace.Controls.Add(this.txtmPassportWorkerTicket);
            this.grpSellTicketPlace.Controls.Add(this.txtmPhoneClientTicket);
            this.grpSellTicketPlace.Controls.Add(this.txtNameWorkerTicket);
            this.grpSellTicketPlace.Controls.Add(this.txtNameClientTicket);
            this.grpSellTicketPlace.Controls.Add(this.lblPhoneClientTicket);
            this.grpSellTicketPlace.Controls.Add(this.lblNameWorkerTicket);
            this.grpSellTicketPlace.Controls.Add(this.lblPassportWorkerTicket);
            this.grpSellTicketPlace.Controls.Add(this.lblNameClientTicket);
            this.grpSellTicketPlace.Controls.Add(this.btnAddTicket);
            this.grpSellTicketPlace.Controls.Add(this.txtmCostTicket);
            this.grpSellTicketPlace.Controls.Add(this.txtNumTicket);
            this.grpSellTicketPlace.Controls.Add(this.lblCostTicket);
            this.grpSellTicketPlace.Controls.Add(this.lblNumTicket);
            this.grpSellTicketPlace.Controls.Add(this.lblRowSellTicket);
            this.grpSellTicketPlace.Controls.Add(this.lblPlaceSellTicket);
            this.grpSellTicketPlace.Enabled = false;
            this.grpSellTicketPlace.Location = new System.Drawing.Point(10, 173);
            this.grpSellTicketPlace.Name = "grpSellTicketPlace";
            this.grpSellTicketPlace.Size = new System.Drawing.Size(194, 440);
            this.grpSellTicketPlace.TabIndex = 11;
            this.grpSellTicketPlace.TabStop = false;
            this.grpSellTicketPlace.Text = "Место";
            // 
            // lblNumRowTicket
            // 
            this.lblNumRowTicket.AutoSize = true;
            this.lblNumRowTicket.Location = new System.Drawing.Point(50, 53);
            this.lblNumRowTicket.Name = "lblNumRowTicket";
            this.lblNumRowTicket.Size = new System.Drawing.Size(0, 13);
            this.lblNumRowTicket.TabIndex = 67;
            // 
            // lblNumPlaceTicket
            // 
            this.lblNumPlaceTicket.AutoSize = true;
            this.lblNumPlaceTicket.Location = new System.Drawing.Point(50, 28);
            this.lblNumPlaceTicket.Name = "lblNumPlaceTicket";
            this.lblNumPlaceTicket.Size = new System.Drawing.Size(0, 13);
            this.lblNumPlaceTicket.TabIndex = 66;
            // 
            // txtmPassportWorkerTicket
            // 
            this.txtmPassportWorkerTicket.CausesValidation = false;
            this.txtmPassportWorkerTicket.Location = new System.Drawing.Point(10, 352);
            this.txtmPassportWorkerTicket.Mask = "0000000000";
            this.txtmPassportWorkerTicket.Name = "txtmPassportWorkerTicket";
            this.txtmPassportWorkerTicket.Size = new System.Drawing.Size(156, 20);
            this.txtmPassportWorkerTicket.TabIndex = 65;
            this.txtmPassportWorkerTicket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmPassportWorkerTicket_MouseClick);
            this.txtmPassportWorkerTicket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmPassportWorkerTicket_KeyDown);
            this.txtmPassportWorkerTicket.Validating += new System.ComponentModel.CancelEventHandler(this.txtmPassportWorkerTicket_Validating);
            // 
            // txtmPhoneClientTicket
            // 
            this.txtmPhoneClientTicket.CausesValidation = false;
            this.txtmPhoneClientTicket.Location = new System.Drawing.Point(10, 249);
            this.txtmPhoneClientTicket.Mask = "+70000000000";
            this.txtmPhoneClientTicket.Name = "txtmPhoneClientTicket";
            this.txtmPhoneClientTicket.Size = new System.Drawing.Size(156, 20);
            this.txtmPhoneClientTicket.TabIndex = 25;
            this.txtmPhoneClientTicket.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmPhoneClientTicket_MouseClick);
            this.txtmPhoneClientTicket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmPhoneClientTicket_KeyDown);
            this.txtmPhoneClientTicket.Validating += new System.ComponentModel.CancelEventHandler(this.txtmPhoneClientTicket_Validating);
            // 
            // txtNameWorkerTicket
            // 
            this.txtNameWorkerTicket.CausesValidation = false;
            this.txtNameWorkerTicket.Location = new System.Drawing.Point(10, 301);
            this.txtNameWorkerTicket.MaxLength = 50;
            this.txtNameWorkerTicket.Name = "txtNameWorkerTicket";
            this.txtNameWorkerTicket.Size = new System.Drawing.Size(156, 20);
            this.txtNameWorkerTicket.TabIndex = 24;
            this.txtNameWorkerTicket.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameWorkerTicket_Validating);
            // 
            // txtNameClientTicket
            // 
            this.txtNameClientTicket.CausesValidation = false;
            this.txtNameClientTicket.Location = new System.Drawing.Point(10, 198);
            this.txtNameClientTicket.MaxLength = 50;
            this.txtNameClientTicket.Name = "txtNameClientTicket";
            this.txtNameClientTicket.Size = new System.Drawing.Size(156, 20);
            this.txtNameClientTicket.TabIndex = 23;
            this.txtNameClientTicket.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameClientTicket_Validating);
            // 
            // lblPhoneClientTicket
            // 
            this.lblPhoneClientTicket.AutoSize = true;
            this.lblPhoneClientTicket.Location = new System.Drawing.Point(7, 233);
            this.lblPhoneClientTicket.Name = "lblPhoneClientTicket";
            this.lblPhoneClientTicket.Size = new System.Drawing.Size(96, 13);
            this.lblPhoneClientTicket.TabIndex = 22;
            this.lblPhoneClientTicket.Text = "Телефон клиента";
            // 
            // lblNameWorkerTicket
            // 
            this.lblNameWorkerTicket.AutoSize = true;
            this.lblNameWorkerTicket.Location = new System.Drawing.Point(7, 285);
            this.lblNameWorkerTicket.Name = "lblNameWorkerTicket";
            this.lblNameWorkerTicket.Size = new System.Drawing.Size(95, 13);
            this.lblNameWorkerTicket.TabIndex = 21;
            this.lblNameWorkerTicket.Text = "ФИО сотрудника";
            // 
            // lblPassportWorkerTicket
            // 
            this.lblPassportWorkerTicket.AutoSize = true;
            this.lblPassportWorkerTicket.Location = new System.Drawing.Point(7, 336);
            this.lblPassportWorkerTicket.Name = "lblPassportWorkerTicket";
            this.lblPassportWorkerTicket.Size = new System.Drawing.Size(172, 13);
            this.lblPassportWorkerTicket.TabIndex = 20;
            this.lblPassportWorkerTicket.Text = "Паспортные данные сотрудника";
            // 
            // lblNameClientTicket
            // 
            this.lblNameClientTicket.AutoSize = true;
            this.lblNameClientTicket.Location = new System.Drawing.Point(7, 182);
            this.lblNameClientTicket.Name = "lblNameClientTicket";
            this.lblNameClientTicket.Size = new System.Drawing.Size(78, 13);
            this.lblNameClientTicket.TabIndex = 19;
            this.lblNameClientTicket.Text = "ФИО клиента";
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Location = new System.Drawing.Point(10, 406);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(176, 23);
            this.btnAddTicket.TabIndex = 17;
            this.btnAddTicket.Text = "Купить";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click_1);
            // 
            // txtmCostTicket
            // 
            this.txtmCostTicket.CausesValidation = false;
            this.txtmCostTicket.Location = new System.Drawing.Point(9, 150);
            this.txtmCostTicket.Name = "txtmCostTicket";
            this.txtmCostTicket.Size = new System.Drawing.Size(157, 20);
            this.txtmCostTicket.TabIndex = 16;
            this.txtmCostTicket.Text = "250";
            this.txtmCostTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmCostTicket_KeyPress_1);
            this.txtmCostTicket.Validating += new System.ComponentModel.CancelEventHandler(this.txtmCostTicket_Validating);
            // 
            // txtNumTicket
            // 
            this.txtNumTicket.CausesValidation = false;
            this.txtNumTicket.Location = new System.Drawing.Point(9, 96);
            this.txtNumTicket.MaxLength = 6;
            this.txtNumTicket.Name = "txtNumTicket";
            this.txtNumTicket.Size = new System.Drawing.Size(157, 20);
            this.txtNumTicket.TabIndex = 15;
            this.txtNumTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTicket_KeyPress);
            this.txtNumTicket.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumTicket_Validating);
            // 
            // lblCostTicket
            // 
            this.lblCostTicket.AutoSize = true;
            this.lblCostTicket.Location = new System.Drawing.Point(6, 134);
            this.lblCostTicket.Name = "lblCostTicket";
            this.lblCostTicket.Size = new System.Drawing.Size(71, 13);
            this.lblCostTicket.TabIndex = 14;
            this.lblCostTicket.Text = "Цена билета";
            // 
            // lblNumTicket
            // 
            this.lblNumTicket.AutoSize = true;
            this.lblNumTicket.Location = new System.Drawing.Point(6, 80);
            this.lblNumTicket.Name = "lblNumTicket";
            this.lblNumTicket.Size = new System.Drawing.Size(79, 13);
            this.lblNumTicket.TabIndex = 13;
            this.lblNumTicket.Text = "Номер билета";
            // 
            // lblRowSellTicket
            // 
            this.lblRowSellTicket.AutoSize = true;
            this.lblRowSellTicket.Location = new System.Drawing.Point(6, 53);
            this.lblRowSellTicket.Name = "lblRowSellTicket";
            this.lblRowSellTicket.Size = new System.Drawing.Size(29, 13);
            this.lblRowSellTicket.TabIndex = 12;
            this.lblRowSellTicket.Text = "Ряд:";
            // 
            // lblPlaceSellTicket
            // 
            this.lblPlaceSellTicket.AutoSize = true;
            this.lblPlaceSellTicket.Location = new System.Drawing.Point(6, 28);
            this.lblPlaceSellTicket.Name = "lblPlaceSellTicket";
            this.lblPlaceSellTicket.Size = new System.Drawing.Size(42, 13);
            this.lblPlaceSellTicket.TabIndex = 11;
            this.lblPlaceSellTicket.Text = "Место:";
            // 
            // cboNumHallTicket
            // 
            this.cboNumHallTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumHallTicket.FormattingEnabled = true;
            this.cboNumHallTicket.Location = new System.Drawing.Point(129, 104);
            this.cboNumHallTicket.Name = "cboNumHallTicket";
            this.cboNumHallTicket.Size = new System.Drawing.Size(237, 21);
            this.cboNumHallTicket.TabIndex = 8;
            this.cboNumHallTicket.SelectionChangeCommitted += new System.EventHandler(this.cboNumHallTicket_SelectionChangeCommitted);
            // 
            // lblNumHallTicket
            // 
            this.lblNumHallTicket.AutoSize = true;
            this.lblNumHallTicket.Location = new System.Drawing.Point(7, 112);
            this.lblNumHallTicket.Name = "lblNumHallTicket";
            this.lblNumHallTicket.Size = new System.Drawing.Size(68, 13);
            this.lblNumHallTicket.TabIndex = 7;
            this.lblNumHallTicket.Text = "Номер зала";
            // 
            // btnShowFilmTicket
            // 
            this.btnShowFilmTicket.Location = new System.Drawing.Point(195, 146);
            this.btnShowFilmTicket.Name = "btnShowFilmTicket";
            this.btnShowFilmTicket.Size = new System.Drawing.Size(171, 21);
            this.btnShowFilmTicket.TabIndex = 6;
            this.btnShowFilmTicket.Text = "Показать фильмы";
            this.btnShowFilmTicket.UseVisualStyleBackColor = true;
            this.btnShowFilmTicket.Click += new System.EventHandler(this.btnShowFilmTicket_Click);
            // 
            // cboDateSessionTicket
            // 
            this.cboDateSessionTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDateSessionTicket.FormattingEnabled = true;
            this.cboDateSessionTicket.Location = new System.Drawing.Point(129, 77);
            this.cboDateSessionTicket.Name = "cboDateSessionTicket";
            this.cboDateSessionTicket.Size = new System.Drawing.Size(237, 21);
            this.cboDateSessionTicket.TabIndex = 5;
            this.cboDateSessionTicket.SelectedIndexChanged += new System.EventHandler(this.cboDateSessionTicket_SelectedIndexChanged);
            // 
            // cboNameFilmTicket
            // 
            this.cboNameFilmTicket.DisplayMember = "Название_фильма";
            this.cboNameFilmTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNameFilmTicket.FormattingEnabled = true;
            this.cboNameFilmTicket.Location = new System.Drawing.Point(129, 23);
            this.cboNameFilmTicket.Name = "cboNameFilmTicket";
            this.cboNameFilmTicket.Size = new System.Drawing.Size(237, 21);
            this.cboNameFilmTicket.TabIndex = 3;
            this.cboNameFilmTicket.ValueMember = "Название_фильма";
            this.cboNameFilmTicket.SelectionChangeCommitted += new System.EventHandler(this.cboNameFilmTicket_SelectionChangeCommitted);
            // 
            // lblDateSessionTicket
            // 
            this.lblDateSessionTicket.AutoSize = true;
            this.lblDateSessionTicket.Location = new System.Drawing.Point(7, 85);
            this.lblDateSessionTicket.Name = "lblDateSessionTicket";
            this.lblDateSessionTicket.Size = new System.Drawing.Size(116, 13);
            this.lblDateSessionTicket.TabIndex = 2;
            this.lblDateSessionTicket.Text = "Дата и время сеанса";
            // 
            // lblNameFilmTicket
            // 
            this.lblNameFilmTicket.AutoSize = true;
            this.lblNameFilmTicket.Location = new System.Drawing.Point(7, 31);
            this.lblNameFilmTicket.Name = "lblNameFilmTicket";
            this.lblNameFilmTicket.Size = new System.Drawing.Size(100, 13);
            this.lblNameFilmTicket.TabIndex = 0;
            this.lblNameFilmTicket.Text = "Название фильма";
            // 
            // grpTicket
            // 
            this.grpTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTicket.Controls.Add(this.lblNumberTicketDelete);
            this.grpTicket.Controls.Add(this.lblNumTicketDelete);
            this.grpTicket.Controls.Add(this.btnDeleteTicket);
            this.grpTicket.Controls.Add(this.dgvwTicket);
            this.grpTicket.Location = new System.Drawing.Point(704, 6);
            this.grpTicket.Name = "grpTicket";
            this.grpTicket.Size = new System.Drawing.Size(474, 203);
            this.grpTicket.TabIndex = 0;
            this.grpTicket.TabStop = false;
            this.grpTicket.Text = "Список билетов";
            // 
            // lblNumberTicketDelete
            // 
            this.lblNumberTicketDelete.AutoSize = true;
            this.lblNumberTicketDelete.Location = new System.Drawing.Point(94, 179);
            this.lblNumberTicketDelete.Name = "lblNumberTicketDelete";
            this.lblNumberTicketDelete.Size = new System.Drawing.Size(0, 13);
            this.lblNumberTicketDelete.TabIndex = 12;
            // 
            // lblNumTicketDelete
            // 
            this.lblNumTicketDelete.AutoSize = true;
            this.lblNumTicketDelete.Location = new System.Drawing.Point(6, 179);
            this.lblNumTicketDelete.Name = "lblNumTicketDelete";
            this.lblNumTicketDelete.Size = new System.Drawing.Size(82, 13);
            this.lblNumTicketDelete.TabIndex = 11;
            this.lblNumTicketDelete.Text = "Номер билета:";
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Location = new System.Drawing.Point(339, 174);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(132, 23);
            this.btnDeleteTicket.TabIndex = 10;
            this.btnDeleteTicket.Text = "Удалить билет";
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // dgvwTicket
            // 
            this.dgvwTicket.AllowUserToAddRows = false;
            this.dgvwTicket.AllowUserToDeleteRows = false;
            this.dgvwTicket.AutoGenerateColumns = false;
            this.dgvwTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номербилетаDataGridViewTextBoxColumn,
            this.ценабилетаDataGridViewTextBoxColumn,
            this.датаивремяпродажибилетаDataGridViewTextBoxColumn});
            this.dgvwTicket.DataSource = this.билетBindingSource;
            this.dgvwTicket.Location = new System.Drawing.Point(3, 16);
            this.dgvwTicket.Name = "dgvwTicket";
            this.dgvwTicket.ReadOnly = true;
            this.dgvwTicket.Size = new System.Drawing.Size(468, 151);
            this.dgvwTicket.TabIndex = 9;
            this.dgvwTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwTicket_CellClick);
            // 
            // номербилетаDataGridViewTextBoxColumn
            // 
            this.номербилетаDataGridViewTextBoxColumn.DataPropertyName = "Номер_билета";
            this.номербилетаDataGridViewTextBoxColumn.HeaderText = "Номер_билета";
            this.номербилетаDataGridViewTextBoxColumn.Name = "номербилетаDataGridViewTextBoxColumn";
            this.номербилетаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номербилетаDataGridViewTextBoxColumn.Width = 107;
            // 
            // ценабилетаDataGridViewTextBoxColumn
            // 
            this.ценабилетаDataGridViewTextBoxColumn.DataPropertyName = "Цена_билета";
            this.ценабилетаDataGridViewTextBoxColumn.HeaderText = "Цена_билета";
            this.ценабилетаDataGridViewTextBoxColumn.Name = "ценабилетаDataGridViewTextBoxColumn";
            this.ценабилетаDataGridViewTextBoxColumn.ReadOnly = true;
            this.ценабилетаDataGridViewTextBoxColumn.Width = 99;
            // 
            // датаивремяпродажибилетаDataGridViewTextBoxColumn
            // 
            this.датаивремяпродажибилетаDataGridViewTextBoxColumn.DataPropertyName = "Дата_и_время_продажи_билета";
            this.датаивремяпродажибилетаDataGridViewTextBoxColumn.HeaderText = "Дата_и_время_продажи_билета";
            this.датаивремяпродажибилетаDataGridViewTextBoxColumn.Name = "датаивремяпродажибилетаDataGridViewTextBoxColumn";
            this.датаивремяпродажибилетаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаивремяпродажибилетаDataGridViewTextBoxColumn.Width = 199;
            // 
            // билетBindingSource
            // 
            this.билетBindingSource.DataMember = "Билет";
            this.билетBindingSource.DataSource = this.ticketDataSet;
            // 
            // ticketDataSet
            // 
            this.ticketDataSet.DataSetName = "TicketDataSet";
            this.ticketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.reportViewer1);
            this.tabPage14.Location = new System.Drawing.Point(4, 22);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(1184, 631);
            this.tabPage14.TabIndex = 2;
            this.tabPage14.Text = "Отчет о клиентах";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource88.Name = "Client";
            reportDataSource88.Value = this.Топ_клиентовBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource88);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cinema.Client.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1178, 625);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabReportTicket
            // 
            this.tabReportTicket.Controls.Add(this.reportViewer3);
            this.tabReportTicket.Location = new System.Drawing.Point(4, 22);
            this.tabReportTicket.Name = "tabReportTicket";
            this.tabReportTicket.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportTicket.Size = new System.Drawing.Size(1184, 631);
            this.tabReportTicket.TabIndex = 3;
            this.tabReportTicket.Text = "Отчет о проданных билетах";
            this.tabReportTicket.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource89.Name = "DataSet1";
            reportDataSource89.Value = this.Продажа_билетовBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource89);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Cinema.SoldTicket.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1178, 625);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.grpLicense);
            this.tabPage3.Controls.Add(this.grpAcquisitionLicense);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1198, 663);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Менеджер по закупкам лицензий";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpLicense
            // 
            this.grpLicense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLicense.Controls.Add(this.dtmLicenseValidityPeriod);
            this.grpLicense.Controls.Add(this.dgvwLicense);
            this.grpLicense.Controls.Add(this.txtNumLicense);
            this.grpLicense.Controls.Add(this.lblNumLicense);
            this.grpLicense.Controls.Add(this.btnDeleteLicense);
            this.grpLicense.Controls.Add(this.btnUpdateLicense);
            this.grpLicense.Controls.Add(this.txtCostLicense);
            this.grpLicense.Controls.Add(this.btnAddLicense);
            this.grpLicense.Controls.Add(this.txtDescriptionLicense);
            this.grpLicense.Controls.Add(this.lblCostLicense);
            this.grpLicense.Controls.Add(this.lblDescriptionLicense);
            this.grpLicense.Controls.Add(this.lblValidityLicense);
            this.grpLicense.Location = new System.Drawing.Point(8, 337);
            this.grpLicense.Name = "grpLicense";
            this.grpLicense.Size = new System.Drawing.Size(1182, 318);
            this.grpLicense.TabIndex = 20;
            this.grpLicense.TabStop = false;
            this.grpLicense.Text = "Лицензия";
            // 
            // dtmLicenseValidityPeriod
            // 
            this.dtmLicenseValidityPeriod.CausesValidation = false;
            this.dtmLicenseValidityPeriod.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtmLicenseValidityPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmLicenseValidityPeriod.Location = new System.Drawing.Point(6, 214);
            this.dtmLicenseValidityPeriod.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtmLicenseValidityPeriod.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtmLicenseValidityPeriod.Name = "dtmLicenseValidityPeriod";
            this.dtmLicenseValidityPeriod.Size = new System.Drawing.Size(226, 20);
            this.dtmLicenseValidityPeriod.TabIndex = 55;
            this.dtmLicenseValidityPeriod.Enter += new System.EventHandler(this.dtmLicenseValidityPeriod_Enter);
            // 
            // dgvwLicense
            // 
            this.dgvwLicense.AllowUserToAddRows = false;
            this.dgvwLicense.AllowUserToDeleteRows = false;
            this.dgvwLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwLicense.AutoGenerateColumns = false;
            this.dgvwLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwLicense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерлицензииDataGridViewTextBoxColumn1,
            this.стоимостьлицензииDataGridViewTextBoxColumn,
            this.описаниелицензииDataGridViewTextBoxColumn,
            this.сроклицензииDataGridViewTextBoxColumn});
            this.dgvwLicense.DataSource = this.лицензияBindingSource;
            this.dgvwLicense.Location = new System.Drawing.Point(253, 19);
            this.dgvwLicense.Name = "dgvwLicense";
            this.dgvwLicense.ReadOnly = true;
            this.dgvwLicense.Size = new System.Drawing.Size(923, 293);
            this.dgvwLicense.TabIndex = 32;
            this.dgvwLicense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwLicense_CellClick);
            // 
            // номерлицензииDataGridViewTextBoxColumn1
            // 
            this.номерлицензииDataGridViewTextBoxColumn1.DataPropertyName = "Номер_лицензии";
            this.номерлицензииDataGridViewTextBoxColumn1.HeaderText = "Номер_лицензии";
            this.номерлицензииDataGridViewTextBoxColumn1.Name = "номерлицензииDataGridViewTextBoxColumn1";
            this.номерлицензииDataGridViewTextBoxColumn1.ReadOnly = true;
            this.номерлицензииDataGridViewTextBoxColumn1.Width = 120;
            // 
            // стоимостьлицензииDataGridViewTextBoxColumn
            // 
            this.стоимостьлицензииDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_лицензии";
            this.стоимостьлицензииDataGridViewTextBoxColumn.HeaderText = "Стоимость_лицензии";
            this.стоимостьлицензииDataGridViewTextBoxColumn.Name = "стоимостьлицензииDataGridViewTextBoxColumn";
            this.стоимостьлицензииDataGridViewTextBoxColumn.ReadOnly = true;
            this.стоимостьлицензииDataGridViewTextBoxColumn.Width = 141;
            // 
            // описаниелицензииDataGridViewTextBoxColumn
            // 
            this.описаниелицензииDataGridViewTextBoxColumn.DataPropertyName = "Описание_лицензии";
            this.описаниелицензииDataGridViewTextBoxColumn.HeaderText = "Описание_лицензии";
            this.описаниелицензииDataGridViewTextBoxColumn.Name = "описаниелицензииDataGridViewTextBoxColumn";
            this.описаниелицензииDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниелицензииDataGridViewTextBoxColumn.Width = 136;
            // 
            // сроклицензииDataGridViewTextBoxColumn
            // 
            this.сроклицензииDataGridViewTextBoxColumn.DataPropertyName = "Срок_лицензии";
            this.сроклицензииDataGridViewTextBoxColumn.HeaderText = "Срок_лицензии";
            this.сроклицензииDataGridViewTextBoxColumn.Name = "сроклицензииDataGridViewTextBoxColumn";
            this.сроклицензииDataGridViewTextBoxColumn.ReadOnly = true;
            this.сроклицензииDataGridViewTextBoxColumn.Width = 111;
            // 
            // лицензияBindingSource
            // 
            this.лицензияBindingSource.DataMember = "Лицензия";
            this.лицензияBindingSource.DataSource = this.lisenseListDataSet;
            // 
            // lisenseListDataSet
            // 
            this.lisenseListDataSet.DataSetName = "LisenseListDataSet";
            this.lisenseListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumLicense
            // 
            this.txtNumLicense.CausesValidation = false;
            this.txtNumLicense.Location = new System.Drawing.Point(7, 40);
            this.txtNumLicense.MaxLength = 7;
            this.txtNumLicense.Name = "txtNumLicense";
            this.txtNumLicense.Size = new System.Drawing.Size(225, 20);
            this.txtNumLicense.TabIndex = 20;
            this.txtNumLicense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumLicense_KeyPress);
            this.txtNumLicense.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumLicense_Validating);
            // 
            // lblNumLicense
            // 
            this.lblNumLicense.AutoSize = true;
            this.lblNumLicense.Location = new System.Drawing.Point(4, 24);
            this.lblNumLicense.Name = "lblNumLicense";
            this.lblNumLicense.Size = new System.Drawing.Size(92, 13);
            this.lblNumLicense.TabIndex = 19;
            this.lblNumLicense.Text = "Номер лицензии";
            // 
            // btnDeleteLicense
            // 
            this.btnDeleteLicense.Location = new System.Drawing.Point(162, 253);
            this.btnDeleteLicense.Name = "btnDeleteLicense";
            this.btnDeleteLicense.Size = new System.Drawing.Size(69, 23);
            this.btnDeleteLicense.TabIndex = 27;
            this.btnDeleteLicense.Text = "Удалить";
            this.btnDeleteLicense.UseVisualStyleBackColor = true;
            this.btnDeleteLicense.Click += new System.EventHandler(this.btnDeleteLicense_Click);
            // 
            // btnUpdateLicense
            // 
            this.btnUpdateLicense.Location = new System.Drawing.Point(81, 253);
            this.btnUpdateLicense.Name = "btnUpdateLicense";
            this.btnUpdateLicense.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateLicense.TabIndex = 31;
            this.btnUpdateLicense.Text = "Обновить";
            this.btnUpdateLicense.UseVisualStyleBackColor = true;
            this.btnUpdateLicense.Click += new System.EventHandler(this.btnUpdateLicense_Click);
            // 
            // txtCostLicense
            // 
            this.txtCostLicense.CausesValidation = false;
            this.txtCostLicense.Location = new System.Drawing.Point(6, 95);
            this.txtCostLicense.MaxLength = 7;
            this.txtCostLicense.Name = "txtCostLicense";
            this.txtCostLicense.Size = new System.Drawing.Size(225, 20);
            this.txtCostLicense.TabIndex = 30;
            this.txtCostLicense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostLicense_KeyPress);
            this.txtCostLicense.Validating += new System.ComponentModel.CancelEventHandler(this.txtCostLicense_Validating);
            // 
            // btnAddLicense
            // 
            this.btnAddLicense.Location = new System.Drawing.Point(7, 253);
            this.btnAddLicense.Name = "btnAddLicense";
            this.btnAddLicense.Size = new System.Drawing.Size(69, 23);
            this.btnAddLicense.TabIndex = 26;
            this.btnAddLicense.Text = "Добавить";
            this.btnAddLicense.UseVisualStyleBackColor = true;
            this.btnAddLicense.Click += new System.EventHandler(this.btnAddLicense_Click);
            // 
            // txtDescriptionLicense
            // 
            this.txtDescriptionLicense.CausesValidation = false;
            this.txtDescriptionLicense.Location = new System.Drawing.Point(6, 153);
            this.txtDescriptionLicense.MaxLength = 50;
            this.txtDescriptionLicense.Name = "txtDescriptionLicense";
            this.txtDescriptionLicense.Size = new System.Drawing.Size(225, 20);
            this.txtDescriptionLicense.TabIndex = 29;
            this.txtDescriptionLicense.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescriptionLicense_Validating);
            // 
            // lblCostLicense
            // 
            this.lblCostLicense.AutoSize = true;
            this.lblCostLicense.Location = new System.Drawing.Point(4, 79);
            this.lblCostLicense.Name = "lblCostLicense";
            this.lblCostLicense.Size = new System.Drawing.Size(113, 13);
            this.lblCostLicense.TabIndex = 21;
            this.lblCostLicense.Text = "Стоимость лицензии";
            // 
            // lblDescriptionLicense
            // 
            this.lblDescriptionLicense.AutoSize = true;
            this.lblDescriptionLicense.Location = new System.Drawing.Point(3, 137);
            this.lblDescriptionLicense.Name = "lblDescriptionLicense";
            this.lblDescriptionLicense.Size = new System.Drawing.Size(108, 13);
            this.lblDescriptionLicense.TabIndex = 22;
            this.lblDescriptionLicense.Text = "Описание лицензии";
            // 
            // lblValidityLicense
            // 
            this.lblValidityLicense.AutoSize = true;
            this.lblValidityLicense.Location = new System.Drawing.Point(4, 198);
            this.lblValidityLicense.Name = "lblValidityLicense";
            this.lblValidityLicense.Size = new System.Drawing.Size(82, 13);
            this.lblValidityLicense.TabIndex = 23;
            this.lblValidityLicense.Text = "Срок действия";
            // 
            // grpAcquisitionLicense
            // 
            this.grpAcquisitionLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAcquisitionLicense.Controls.Add(this.numYearFilmAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.txtmPassportWorkerAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.txtTitlePostAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.lblTitlePostAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.dgvwAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.txtNumAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.lblNumAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.btnDeleteAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.txtNameFilmAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.txtNameWorkerAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.btnAddAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.lblNameFilmAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.lblYearFilmAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.lblPassportWorkerAcquisitionLicense);
            this.grpAcquisitionLicense.Controls.Add(this.lblNameWorkerAcquisitionLicense);
            this.grpAcquisitionLicense.Location = new System.Drawing.Point(8, 11);
            this.grpAcquisitionLicense.Name = "grpAcquisitionLicense";
            this.grpAcquisitionLicense.Size = new System.Drawing.Size(1182, 320);
            this.grpAcquisitionLicense.TabIndex = 21;
            this.grpAcquisitionLicense.TabStop = false;
            this.grpAcquisitionLicense.Text = "Приобретение лицензии";
            // 
            // numYearFilmAcquisitionLicense
            // 
            this.numYearFilmAcquisitionLicense.CausesValidation = false;
            this.numYearFilmAcquisitionLicense.Location = new System.Drawing.Point(6, 117);
            this.numYearFilmAcquisitionLicense.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numYearFilmAcquisitionLicense.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearFilmAcquisitionLicense.Name = "numYearFilmAcquisitionLicense";
            this.numYearFilmAcquisitionLicense.ReadOnly = true;
            this.numYearFilmAcquisitionLicense.Size = new System.Drawing.Size(225, 20);
            this.numYearFilmAcquisitionLicense.TabIndex = 47;
            this.numYearFilmAcquisitionLicense.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // txtmPassportWorkerAcquisitionLicense
            // 
            this.txtmPassportWorkerAcquisitionLicense.CausesValidation = false;
            this.txtmPassportWorkerAcquisitionLicense.Location = new System.Drawing.Point(7, 195);
            this.txtmPassportWorkerAcquisitionLicense.Mask = "0000000000";
            this.txtmPassportWorkerAcquisitionLicense.Name = "txtmPassportWorkerAcquisitionLicense";
            this.txtmPassportWorkerAcquisitionLicense.Size = new System.Drawing.Size(224, 20);
            this.txtmPassportWorkerAcquisitionLicense.TabIndex = 43;
            this.txtmPassportWorkerAcquisitionLicense.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmPassportWorkerAcquisitionLicense_MouseClick);
            this.txtmPassportWorkerAcquisitionLicense.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmPassportWorkerAcquisitionLicense_KeyDown);
            this.txtmPassportWorkerAcquisitionLicense.Validating += new System.ComponentModel.CancelEventHandler(this.txtmPassportWorkerAcquisitionLicense_Validating);
            // 
            // txtTitlePostAcquisitionLicense
            // 
            this.txtTitlePostAcquisitionLicense.CausesValidation = false;
            this.txtTitlePostAcquisitionLicense.Location = new System.Drawing.Point(7, 234);
            this.txtTitlePostAcquisitionLicense.MaxLength = 50;
            this.txtTitlePostAcquisitionLicense.Name = "txtTitlePostAcquisitionLicense";
            this.txtTitlePostAcquisitionLicense.Size = new System.Drawing.Size(225, 20);
            this.txtTitlePostAcquisitionLicense.TabIndex = 41;
            this.txtTitlePostAcquisitionLicense.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitlePostAcquisitionLicense_Validating);
            // 
            // lblTitlePostAcquisitionLicense
            // 
            this.lblTitlePostAcquisitionLicense.AutoSize = true;
            this.lblTitlePostAcquisitionLicense.Location = new System.Drawing.Point(4, 218);
            this.lblTitlePostAcquisitionLicense.Name = "lblTitlePostAcquisitionLicense";
            this.lblTitlePostAcquisitionLicense.Size = new System.Drawing.Size(115, 13);
            this.lblTitlePostAcquisitionLicense.TabIndex = 40;
            this.lblTitlePostAcquisitionLicense.Text = "Название должности";
            // 
            // dgvwAcquisitionLicense
            // 
            this.dgvwAcquisitionLicense.AllowUserToAddRows = false;
            this.dgvwAcquisitionLicense.AllowUserToDeleteRows = false;
            this.dgvwAcquisitionLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwAcquisitionLicense.AutoGenerateColumns = false;
            this.dgvwAcquisitionLicense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwAcquisitionLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwAcquisitionLicense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерлицензииDataGridViewTextBoxColumn,
            this.названиефильмаDataGridViewTextBoxColumn,
            this.годвыпускаDataGridViewTextBoxColumn,
            this.фИОсотрудникаDataGridViewTextBoxColumn,
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn,
            this.названиедолжностиDataGridViewTextBoxColumn});
            this.dgvwAcquisitionLicense.DataSource = this.приобретениелицензииBindingSource;
            this.dgvwAcquisitionLicense.Location = new System.Drawing.Point(253, 19);
            this.dgvwAcquisitionLicense.Name = "dgvwAcquisitionLicense";
            this.dgvwAcquisitionLicense.ReadOnly = true;
            this.dgvwAcquisitionLicense.Size = new System.Drawing.Size(923, 295);
            this.dgvwAcquisitionLicense.TabIndex = 19;
            this.dgvwAcquisitionLicense.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwAcquisitionLicense_CellClick);
            // 
            // номерлицензииDataGridViewTextBoxColumn
            // 
            this.номерлицензииDataGridViewTextBoxColumn.DataPropertyName = "Номер_лицензии";
            this.номерлицензииDataGridViewTextBoxColumn.HeaderText = "Номер_лицензии";
            this.номерлицензииDataGridViewTextBoxColumn.Name = "номерлицензииDataGridViewTextBoxColumn";
            this.номерлицензииDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерлицензииDataGridViewTextBoxColumn.Width = 120;
            // 
            // названиефильмаDataGridViewTextBoxColumn
            // 
            this.названиефильмаDataGridViewTextBoxColumn.DataPropertyName = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn.HeaderText = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn.Name = "названиефильмаDataGridViewTextBoxColumn";
            this.названиефильмаDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиефильмаDataGridViewTextBoxColumn.Width = 128;
            // 
            // годвыпускаDataGridViewTextBoxColumn
            // 
            this.годвыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn.HeaderText = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn.Name = "годвыпускаDataGridViewTextBoxColumn";
            this.годвыпускаDataGridViewTextBoxColumn.ReadOnly = true;
            this.годвыпускаDataGridViewTextBoxColumn.Width = 99;
            // 
            // фИОсотрудникаDataGridViewTextBoxColumn
            // 
            this.фИОсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn.HeaderText = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn.Name = "фИОсотрудникаDataGridViewTextBoxColumn";
            this.фИОсотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОсотрудникаDataGridViewTextBoxColumn.Width = 123;
            // 
            // паспортныеданныесотрудникаDataGridViewTextBoxColumn
            // 
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn.HeaderText = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn.Name = "паспортныеданныесотрудникаDataGridViewTextBoxColumn";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn.Width = 203;
            // 
            // названиедолжностиDataGridViewTextBoxColumn
            // 
            this.названиедолжностиDataGridViewTextBoxColumn.DataPropertyName = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn.HeaderText = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn.Name = "названиедолжностиDataGridViewTextBoxColumn";
            this.названиедолжностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиедолжностиDataGridViewTextBoxColumn.Width = 143;
            // 
            // приобретениелицензииBindingSource
            // 
            this.приобретениелицензииBindingSource.DataMember = "Приобретение_лицензии";
            this.приобретениелицензииBindingSource.DataSource = this.licenseDataSet;
            // 
            // licenseDataSet
            // 
            this.licenseDataSet.DataSetName = "LicenseDataSet";
            this.licenseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumAcquisitionLicense
            // 
            this.txtNumAcquisitionLicense.CausesValidation = false;
            this.txtNumAcquisitionLicense.Location = new System.Drawing.Point(6, 39);
            this.txtNumAcquisitionLicense.MaxLength = 3;
            this.txtNumAcquisitionLicense.Name = "txtNumAcquisitionLicense";
            this.txtNumAcquisitionLicense.Size = new System.Drawing.Size(225, 20);
            this.txtNumAcquisitionLicense.TabIndex = 1;
            this.txtNumAcquisitionLicense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAcquisitionLicense_KeyPress);
            this.txtNumAcquisitionLicense.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumAcquisitionLicense_Validating);
            // 
            // lblNumAcquisitionLicense
            // 
            this.lblNumAcquisitionLicense.AutoSize = true;
            this.lblNumAcquisitionLicense.Location = new System.Drawing.Point(3, 23);
            this.lblNumAcquisitionLicense.Name = "lblNumAcquisitionLicense";
            this.lblNumAcquisitionLicense.Size = new System.Drawing.Size(92, 13);
            this.lblNumAcquisitionLicense.TabIndex = 0;
            this.lblNumAcquisitionLicense.Text = "Номер лицензии";
            // 
            // btnDeleteAcquisitionLicense
            // 
            this.btnDeleteAcquisitionLicense.Location = new System.Drawing.Point(117, 271);
            this.btnDeleteAcquisitionLicense.Name = "btnDeleteAcquisitionLicense";
            this.btnDeleteAcquisitionLicense.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteAcquisitionLicense.TabIndex = 14;
            this.btnDeleteAcquisitionLicense.Text = "Удалить";
            this.btnDeleteAcquisitionLicense.UseVisualStyleBackColor = true;
            this.btnDeleteAcquisitionLicense.Click += new System.EventHandler(this.btnDeleteAcquisitionLicense_Click);
            // 
            // txtNameFilmAcquisitionLicense
            // 
            this.txtNameFilmAcquisitionLicense.CausesValidation = false;
            this.txtNameFilmAcquisitionLicense.Location = new System.Drawing.Point(6, 78);
            this.txtNameFilmAcquisitionLicense.MaxLength = 50;
            this.txtNameFilmAcquisitionLicense.Name = "txtNameFilmAcquisitionLicense";
            this.txtNameFilmAcquisitionLicense.Size = new System.Drawing.Size(225, 20);
            this.txtNameFilmAcquisitionLicense.TabIndex = 17;
            this.txtNameFilmAcquisitionLicense.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameFilmAcquisitionLicense_Validating);
            // 
            // txtNameWorkerAcquisitionLicense
            // 
            this.txtNameWorkerAcquisitionLicense.CausesValidation = false;
            this.txtNameWorkerAcquisitionLicense.Location = new System.Drawing.Point(7, 156);
            this.txtNameWorkerAcquisitionLicense.MaxLength = 50;
            this.txtNameWorkerAcquisitionLicense.Name = "txtNameWorkerAcquisitionLicense";
            this.txtNameWorkerAcquisitionLicense.Size = new System.Drawing.Size(225, 20);
            this.txtNameWorkerAcquisitionLicense.TabIndex = 15;
            this.txtNameWorkerAcquisitionLicense.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameWorkerAcquisitionLicense_Validating);
            // 
            // btnAddAcquisitionLicense
            // 
            this.btnAddAcquisitionLicense.Location = new System.Drawing.Point(6, 271);
            this.btnAddAcquisitionLicense.Name = "btnAddAcquisitionLicense";
            this.btnAddAcquisitionLicense.Size = new System.Drawing.Size(105, 23);
            this.btnAddAcquisitionLicense.TabIndex = 12;
            this.btnAddAcquisitionLicense.Text = "Добавить";
            this.btnAddAcquisitionLicense.UseVisualStyleBackColor = true;
            this.btnAddAcquisitionLicense.Click += new System.EventHandler(this.btnAddAcquisitionLicense_Click);
            // 
            // lblNameFilmAcquisitionLicense
            // 
            this.lblNameFilmAcquisitionLicense.AutoSize = true;
            this.lblNameFilmAcquisitionLicense.Location = new System.Drawing.Point(4, 62);
            this.lblNameFilmAcquisitionLicense.Name = "lblNameFilmAcquisitionLicense";
            this.lblNameFilmAcquisitionLicense.Size = new System.Drawing.Size(100, 13);
            this.lblNameFilmAcquisitionLicense.TabIndex = 2;
            this.lblNameFilmAcquisitionLicense.Text = "Название фильма";
            // 
            // lblYearFilmAcquisitionLicense
            // 
            this.lblYearFilmAcquisitionLicense.AutoSize = true;
            this.lblYearFilmAcquisitionLicense.Location = new System.Drawing.Point(3, 101);
            this.lblYearFilmAcquisitionLicense.Name = "lblYearFilmAcquisitionLicense";
            this.lblYearFilmAcquisitionLicense.Size = new System.Drawing.Size(71, 13);
            this.lblYearFilmAcquisitionLicense.TabIndex = 4;
            this.lblYearFilmAcquisitionLicense.Text = "Год выпуска";
            // 
            // lblPassportWorkerAcquisitionLicense
            // 
            this.lblPassportWorkerAcquisitionLicense.AutoSize = true;
            this.lblPassportWorkerAcquisitionLicense.Location = new System.Drawing.Point(3, 179);
            this.lblPassportWorkerAcquisitionLicense.Name = "lblPassportWorkerAcquisitionLicense";
            this.lblPassportWorkerAcquisitionLicense.Size = new System.Drawing.Size(111, 13);
            this.lblPassportWorkerAcquisitionLicense.TabIndex = 9;
            this.lblPassportWorkerAcquisitionLicense.Text = "Паспортные данные";
            // 
            // lblNameWorkerAcquisitionLicense
            // 
            this.lblNameWorkerAcquisitionLicense.AutoSize = true;
            this.lblNameWorkerAcquisitionLicense.Location = new System.Drawing.Point(4, 140);
            this.lblNameWorkerAcquisitionLicense.Name = "lblNameWorkerAcquisitionLicense";
            this.lblNameWorkerAcquisitionLicense.Size = new System.Drawing.Size(95, 13);
            this.lblNameWorkerAcquisitionLicense.TabIndex = 7;
            this.lblNameWorkerAcquisitionLicense.Text = "ФИО сотрудника";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grpShowingFilm);
            this.tabPage4.Controls.Add(this.grpEquipment);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1198, 663);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Киномеханик";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grpShowingFilm
            // 
            this.grpShowingFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpShowingFilm.Controls.Add(this.numYearFilmShowing);
            this.grpShowingFilm.Controls.Add(this.txtmPassportShowing);
            this.grpShowingFilm.Controls.Add(this.txtTitlePostShowing);
            this.grpShowingFilm.Controls.Add(this.lblTitlePostShowing);
            this.grpShowingFilm.Controls.Add(this.dgvwShowingFilm);
            this.grpShowingFilm.Controls.Add(this.btnDeleteShowingFilm);
            this.grpShowingFilm.Controls.Add(this.btnAddShowingFilm);
            this.grpShowingFilm.Controls.Add(this.lblPassportShowing);
            this.grpShowingFilm.Controls.Add(this.txtNameWorkerShowing);
            this.grpShowingFilm.Controls.Add(this.lblNameWorkerShowing);
            this.grpShowingFilm.Controls.Add(this.txtNameFilmShowing);
            this.grpShowingFilm.Controls.Add(this.lblNameFilmShowing);
            this.grpShowingFilm.Controls.Add(this.lblYearFilmShowing);
            this.grpShowingFilm.Controls.Add(this.txtEquipmentIDFilm);
            this.grpShowingFilm.Controls.Add(this.lblEquipmentIDFilm);
            this.grpShowingFilm.Location = new System.Drawing.Point(9, 323);
            this.grpShowingFilm.Name = "grpShowingFilm";
            this.grpShowingFilm.Size = new System.Drawing.Size(1181, 332);
            this.grpShowingFilm.TabIndex = 33;
            this.grpShowingFilm.TabStop = false;
            this.grpShowingFilm.Text = "Показ фильма";
            // 
            // numYearFilmShowing
            // 
            this.numYearFilmShowing.CausesValidation = false;
            this.numYearFilmShowing.Location = new System.Drawing.Point(9, 110);
            this.numYearFilmShowing.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numYearFilmShowing.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYearFilmShowing.Name = "numYearFilmShowing";
            this.numYearFilmShowing.ReadOnly = true;
            this.numYearFilmShowing.Size = new System.Drawing.Size(221, 20);
            this.numYearFilmShowing.TabIndex = 48;
            this.numYearFilmShowing.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // txtmPassportShowing
            // 
            this.txtmPassportShowing.CausesValidation = false;
            this.txtmPassportShowing.Location = new System.Drawing.Point(9, 188);
            this.txtmPassportShowing.Mask = "0000000000";
            this.txtmPassportShowing.Name = "txtmPassportShowing";
            this.txtmPassportShowing.Size = new System.Drawing.Size(221, 20);
            this.txtmPassportShowing.TabIndex = 41;
            this.txtmPassportShowing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmPassportShowing_MouseClick);
            this.txtmPassportShowing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmPassportShowing_KeyDown);
            this.txtmPassportShowing.Validating += new System.ComponentModel.CancelEventHandler(this.txtmPassportShowing_Validating);
            // 
            // txtTitlePostShowing
            // 
            this.txtTitlePostShowing.CausesValidation = false;
            this.txtTitlePostShowing.Location = new System.Drawing.Point(9, 227);
            this.txtTitlePostShowing.Name = "txtTitlePostShowing";
            this.txtTitlePostShowing.Size = new System.Drawing.Size(221, 20);
            this.txtTitlePostShowing.TabIndex = 39;
            this.txtTitlePostShowing.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitlePostShowing_Validating);
            // 
            // lblTitlePostShowing
            // 
            this.lblTitlePostShowing.AutoSize = true;
            this.lblTitlePostShowing.Location = new System.Drawing.Point(6, 211);
            this.lblTitlePostShowing.Name = "lblTitlePostShowing";
            this.lblTitlePostShowing.Size = new System.Drawing.Size(115, 13);
            this.lblTitlePostShowing.TabIndex = 38;
            this.lblTitlePostShowing.Text = "Название должности";
            // 
            // dgvwShowingFilm
            // 
            this.dgvwShowingFilm.AllowUserToAddRows = false;
            this.dgvwShowingFilm.AllowUserToDeleteRows = false;
            this.dgvwShowingFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwShowingFilm.AutoGenerateColumns = false;
            this.dgvwShowingFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwShowingFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwShowingFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDоборудованияDataGridViewTextBoxColumn1,
            this.названиефильмаDataGridViewTextBoxColumn3,
            this.годвыпускаDataGridViewTextBoxColumn3,
            this.фИОсотрудникаDataGridViewTextBoxColumn2,
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn2,
            this.названиедолжностиDataGridViewTextBoxColumn2});
            this.dgvwShowingFilm.DataSource = this.показфильмаBindingSource;
            this.dgvwShowingFilm.Location = new System.Drawing.Point(251, 16);
            this.dgvwShowingFilm.Name = "dgvwShowingFilm";
            this.dgvwShowingFilm.ReadOnly = true;
            this.dgvwShowingFilm.Size = new System.Drawing.Size(924, 310);
            this.dgvwShowingFilm.TabIndex = 37;
            this.dgvwShowingFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwShowingFilm_CellClick);
            // 
            // iDоборудованияDataGridViewTextBoxColumn1
            // 
            this.iDоборудованияDataGridViewTextBoxColumn1.DataPropertyName = "ID_оборудования";
            this.iDоборудованияDataGridViewTextBoxColumn1.HeaderText = "ID_оборудования";
            this.iDоборудованияDataGridViewTextBoxColumn1.Name = "iDоборудованияDataGridViewTextBoxColumn1";
            this.iDоборудованияDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDоборудованияDataGridViewTextBoxColumn1.Width = 120;
            // 
            // названиефильмаDataGridViewTextBoxColumn3
            // 
            this.названиефильмаDataGridViewTextBoxColumn3.DataPropertyName = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn3.HeaderText = "Название_фильма";
            this.названиефильмаDataGridViewTextBoxColumn3.Name = "названиефильмаDataGridViewTextBoxColumn3";
            this.названиефильмаDataGridViewTextBoxColumn3.ReadOnly = true;
            this.названиефильмаDataGridViewTextBoxColumn3.Width = 128;
            // 
            // годвыпускаDataGridViewTextBoxColumn3
            // 
            this.годвыпускаDataGridViewTextBoxColumn3.DataPropertyName = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn3.HeaderText = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn3.Name = "годвыпускаDataGridViewTextBoxColumn3";
            this.годвыпускаDataGridViewTextBoxColumn3.ReadOnly = true;
            this.годвыпускаDataGridViewTextBoxColumn3.Width = 99;
            // 
            // фИОсотрудникаDataGridViewTextBoxColumn2
            // 
            this.фИОсотрудникаDataGridViewTextBoxColumn2.DataPropertyName = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn2.HeaderText = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn2.Name = "фИОсотрудникаDataGridViewTextBoxColumn2";
            this.фИОсотрудникаDataGridViewTextBoxColumn2.ReadOnly = true;
            this.фИОсотрудникаDataGridViewTextBoxColumn2.Width = 123;
            // 
            // паспортныеданныесотрудникаDataGridViewTextBoxColumn2
            // 
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn2.DataPropertyName = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn2.HeaderText = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn2.Name = "паспортныеданныесотрудникаDataGridViewTextBoxColumn2";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn2.ReadOnly = true;
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn2.Width = 203;
            // 
            // названиедолжностиDataGridViewTextBoxColumn2
            // 
            this.названиедолжностиDataGridViewTextBoxColumn2.DataPropertyName = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn2.HeaderText = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn2.Name = "названиедолжностиDataGridViewTextBoxColumn2";
            this.названиедолжностиDataGridViewTextBoxColumn2.ReadOnly = true;
            this.названиедолжностиDataGridViewTextBoxColumn2.Width = 143;
            // 
            // показфильмаBindingSource
            // 
            this.показфильмаBindingSource.DataMember = "Показ_фильма";
            this.показфильмаBindingSource.DataSource = this.showingFilmDataSet;
            // 
            // showingFilmDataSet
            // 
            this.showingFilmDataSet.DataSetName = "ShowingFilmDataSet";
            this.showingFilmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDeleteShowingFilm
            // 
            this.btnDeleteShowingFilm.Location = new System.Drawing.Point(123, 272);
            this.btnDeleteShowingFilm.Name = "btnDeleteShowingFilm";
            this.btnDeleteShowingFilm.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteShowingFilm.TabIndex = 36;
            this.btnDeleteShowingFilm.Text = "Удалить";
            this.btnDeleteShowingFilm.UseVisualStyleBackColor = true;
            this.btnDeleteShowingFilm.Click += new System.EventHandler(this.btnDeleteShowingFilm_Click);
            // 
            // btnAddShowingFilm
            // 
            this.btnAddShowingFilm.Location = new System.Drawing.Point(9, 272);
            this.btnAddShowingFilm.Name = "btnAddShowingFilm";
            this.btnAddShowingFilm.Size = new System.Drawing.Size(108, 23);
            this.btnAddShowingFilm.TabIndex = 35;
            this.btnAddShowingFilm.Text = "Добавить";
            this.btnAddShowingFilm.UseVisualStyleBackColor = true;
            this.btnAddShowingFilm.Click += new System.EventHandler(this.btnAddShowingFilm_Click);
            // 
            // lblPassportShowing
            // 
            this.lblPassportShowing.AutoSize = true;
            this.lblPassportShowing.Location = new System.Drawing.Point(6, 172);
            this.lblPassportShowing.Name = "lblPassportShowing";
            this.lblPassportShowing.Size = new System.Drawing.Size(111, 13);
            this.lblPassportShowing.TabIndex = 33;
            this.lblPassportShowing.Text = "Паспортные данные";
            // 
            // txtNameWorkerShowing
            // 
            this.txtNameWorkerShowing.CausesValidation = false;
            this.txtNameWorkerShowing.Location = new System.Drawing.Point(9, 149);
            this.txtNameWorkerShowing.Name = "txtNameWorkerShowing";
            this.txtNameWorkerShowing.Size = new System.Drawing.Size(221, 20);
            this.txtNameWorkerShowing.TabIndex = 32;
            this.txtNameWorkerShowing.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameWorkerShowing_Validating);
            // 
            // lblNameWorkerShowing
            // 
            this.lblNameWorkerShowing.AutoSize = true;
            this.lblNameWorkerShowing.Location = new System.Drawing.Point(6, 133);
            this.lblNameWorkerShowing.Name = "lblNameWorkerShowing";
            this.lblNameWorkerShowing.Size = new System.Drawing.Size(95, 13);
            this.lblNameWorkerShowing.TabIndex = 31;
            this.lblNameWorkerShowing.Text = "ФИО сотрудника";
            // 
            // txtNameFilmShowing
            // 
            this.txtNameFilmShowing.CausesValidation = false;
            this.txtNameFilmShowing.Location = new System.Drawing.Point(9, 71);
            this.txtNameFilmShowing.Name = "txtNameFilmShowing";
            this.txtNameFilmShowing.Size = new System.Drawing.Size(221, 20);
            this.txtNameFilmShowing.TabIndex = 24;
            this.txtNameFilmShowing.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameFilmShowing_Validating);
            // 
            // lblNameFilmShowing
            // 
            this.lblNameFilmShowing.AutoSize = true;
            this.lblNameFilmShowing.Location = new System.Drawing.Point(6, 55);
            this.lblNameFilmShowing.Name = "lblNameFilmShowing";
            this.lblNameFilmShowing.Size = new System.Drawing.Size(100, 13);
            this.lblNameFilmShowing.TabIndex = 23;
            this.lblNameFilmShowing.Text = "Название фильма";
            // 
            // lblYearFilmShowing
            // 
            this.lblYearFilmShowing.AutoSize = true;
            this.lblYearFilmShowing.Location = new System.Drawing.Point(6, 94);
            this.lblYearFilmShowing.Name = "lblYearFilmShowing";
            this.lblYearFilmShowing.Size = new System.Drawing.Size(71, 13);
            this.lblYearFilmShowing.TabIndex = 22;
            this.lblYearFilmShowing.Text = "Год выпуска";
            // 
            // txtEquipmentIDFilm
            // 
            this.txtEquipmentIDFilm.CausesValidation = false;
            this.txtEquipmentIDFilm.Location = new System.Drawing.Point(9, 32);
            this.txtEquipmentIDFilm.Name = "txtEquipmentIDFilm";
            this.txtEquipmentIDFilm.Size = new System.Drawing.Size(221, 20);
            this.txtEquipmentIDFilm.TabIndex = 21;
            this.txtEquipmentIDFilm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEquipmentIDFilm_KeyPress);
            this.txtEquipmentIDFilm.Validating += new System.ComponentModel.CancelEventHandler(this.txtEquipmentIDFilm_Validating);
            // 
            // lblEquipmentIDFilm
            // 
            this.lblEquipmentIDFilm.AutoSize = true;
            this.lblEquipmentIDFilm.Location = new System.Drawing.Point(6, 16);
            this.lblEquipmentIDFilm.Name = "lblEquipmentIDFilm";
            this.lblEquipmentIDFilm.Size = new System.Drawing.Size(92, 13);
            this.lblEquipmentIDFilm.TabIndex = 20;
            this.lblEquipmentIDFilm.Text = "ID оборудования";
            // 
            // grpEquipment
            // 
            this.grpEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEquipment.Controls.Add(this.dgvwEquipment);
            this.grpEquipment.Controls.Add(this.txtEquipmentID);
            this.grpEquipment.Controls.Add(this.btnUpdateEquipment);
            this.grpEquipment.Controls.Add(this.lblEquipmentID);
            this.grpEquipment.Controls.Add(this.cboEquipmentFormat);
            this.grpEquipment.Controls.Add(this.lblEquipmentFormat);
            this.grpEquipment.Controls.Add(this.txtDescriptionEquipment);
            this.grpEquipment.Controls.Add(this.lblTitleEquipment);
            this.grpEquipment.Controls.Add(this.btnDeleteEquipment);
            this.grpEquipment.Controls.Add(this.btnAddEquipment);
            this.grpEquipment.Location = new System.Drawing.Point(9, 6);
            this.grpEquipment.Name = "grpEquipment";
            this.grpEquipment.Size = new System.Drawing.Size(1181, 311);
            this.grpEquipment.TabIndex = 32;
            this.grpEquipment.TabStop = false;
            this.grpEquipment.Text = "Оборудование";
            // 
            // dgvwEquipment
            // 
            this.dgvwEquipment.AllowUserToAddRows = false;
            this.dgvwEquipment.AllowUserToDeleteRows = false;
            this.dgvwEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwEquipment.AutoGenerateColumns = false;
            this.dgvwEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDоборудованияDataGridViewTextBoxColumn,
            this.форматоборудованияDataGridViewTextBoxColumn,
            this.описаниеоборудованияDataGridViewTextBoxColumn});
            this.dgvwEquipment.DataSource = this.оборудованиеBindingSource;
            this.dgvwEquipment.Location = new System.Drawing.Point(251, 19);
            this.dgvwEquipment.Name = "dgvwEquipment";
            this.dgvwEquipment.ReadOnly = true;
            this.dgvwEquipment.Size = new System.Drawing.Size(924, 286);
            this.dgvwEquipment.TabIndex = 32;
            this.dgvwEquipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwEquipment_CellClick);
            // 
            // iDоборудованияDataGridViewTextBoxColumn
            // 
            this.iDоборудованияDataGridViewTextBoxColumn.DataPropertyName = "ID_оборудования";
            this.iDоборудованияDataGridViewTextBoxColumn.HeaderText = "ID_оборудования";
            this.iDоборудованияDataGridViewTextBoxColumn.Name = "iDоборудованияDataGridViewTextBoxColumn";
            this.iDоборудованияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDоборудованияDataGridViewTextBoxColumn.Width = 120;
            // 
            // форматоборудованияDataGridViewTextBoxColumn
            // 
            this.форматоборудованияDataGridViewTextBoxColumn.DataPropertyName = "Формат_оборудования";
            this.форматоборудованияDataGridViewTextBoxColumn.HeaderText = "Формат_оборудования";
            this.форматоборудованияDataGridViewTextBoxColumn.Name = "форматоборудованияDataGridViewTextBoxColumn";
            this.форматоборудованияDataGridViewTextBoxColumn.ReadOnly = true;
            this.форматоборудованияDataGridViewTextBoxColumn.Width = 151;
            // 
            // описаниеоборудованияDataGridViewTextBoxColumn
            // 
            this.описаниеоборудованияDataGridViewTextBoxColumn.DataPropertyName = "Описание_оборудования";
            this.описаниеоборудованияDataGridViewTextBoxColumn.HeaderText = "Описание_оборудования";
            this.описаниеоборудованияDataGridViewTextBoxColumn.Name = "описаниеоборудованияDataGridViewTextBoxColumn";
            this.описаниеоборудованияDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниеоборудованияDataGridViewTextBoxColumn.Width = 159;
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.equipmentDataSet;
            // 
            // equipmentDataSet
            // 
            this.equipmentDataSet.DataSetName = "EquipmentDataSet";
            this.equipmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.CausesValidation = false;
            this.txtEquipmentID.Location = new System.Drawing.Point(9, 35);
            this.txtEquipmentID.MaxLength = 7;
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.Size = new System.Drawing.Size(221, 20);
            this.txtEquipmentID.TabIndex = 19;
            this.txtEquipmentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEquipmentID_KeyPress);
            this.txtEquipmentID.Validating += new System.ComponentModel.CancelEventHandler(this.txtEquipmentID_Validating);
            // 
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.Location = new System.Drawing.Point(86, 204);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(73, 23);
            this.btnUpdateEquipment.TabIndex = 31;
            this.btnUpdateEquipment.Text = "Обновить";
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Location = new System.Drawing.Point(6, 19);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(92, 13);
            this.lblEquipmentID.TabIndex = 18;
            this.lblEquipmentID.Text = "ID оборудования";
            // 
            // cboEquipmentFormat
            // 
            this.cboEquipmentFormat.CausesValidation = false;
            this.cboEquipmentFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipmentFormat.FormattingEnabled = true;
            this.cboEquipmentFormat.Items.AddRange(new object[] {
            "2D",
            "2D IMAX",
            "3D",
            "3D IMAX"});
            this.cboEquipmentFormat.Location = new System.Drawing.Point(9, 98);
            this.cboEquipmentFormat.Name = "cboEquipmentFormat";
            this.cboEquipmentFormat.Size = new System.Drawing.Size(221, 21);
            this.cboEquipmentFormat.TabIndex = 30;
            this.cboEquipmentFormat.Validating += new System.ComponentModel.CancelEventHandler(this.cboEquipmentFormat_Validating);
            // 
            // lblEquipmentFormat
            // 
            this.lblEquipmentFormat.AutoSize = true;
            this.lblEquipmentFormat.Location = new System.Drawing.Point(6, 82);
            this.lblEquipmentFormat.Name = "lblEquipmentFormat";
            this.lblEquipmentFormat.Size = new System.Drawing.Size(123, 13);
            this.lblEquipmentFormat.TabIndex = 20;
            this.lblEquipmentFormat.Text = "Формат оборудования";
            // 
            // txtDescriptionEquipment
            // 
            this.txtDescriptionEquipment.CausesValidation = false;
            this.txtDescriptionEquipment.Location = new System.Drawing.Point(9, 165);
            this.txtDescriptionEquipment.Name = "txtDescriptionEquipment";
            this.txtDescriptionEquipment.Size = new System.Drawing.Size(221, 20);
            this.txtDescriptionEquipment.TabIndex = 29;
            this.txtDescriptionEquipment.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescriptionEquipment_Validating);
            // 
            // lblTitleEquipment
            // 
            this.lblTitleEquipment.AutoSize = true;
            this.lblTitleEquipment.Location = new System.Drawing.Point(6, 149);
            this.lblTitleEquipment.Name = "lblTitleEquipment";
            this.lblTitleEquipment.Size = new System.Drawing.Size(131, 13);
            this.lblTitleEquipment.TabIndex = 21;
            this.lblTitleEquipment.Text = "Описание оборудования";
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Location = new System.Drawing.Point(165, 204);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(65, 23);
            this.btnDeleteEquipment.TabIndex = 27;
            this.btnDeleteEquipment.Text = "Удалить";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(9, 204);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(71, 23);
            this.btnAddEquipment.TabIndex = 26;
            this.btnAddEquipment.Text = "Добавить";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabReport);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1198, 663);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Менеджер по персоналу";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tabPage11);
            this.tabReport.Controls.Add(this.tabPage12);
            this.tabReport.Controls.Add(this.tabPage18);
            this.tabReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReport.Location = new System.Drawing.Point(3, 3);
            this.tabReport.Name = "tabReport";
            this.tabReport.SelectedIndex = 0;
            this.tabReport.Size = new System.Drawing.Size(1192, 657);
            this.tabReport.TabIndex = 34;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.groupBox1);
            this.tabPage11.Controls.Add(this.grpWorkerHall);
            this.tabPage11.Controls.Add(this.grpWorker);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1184, 631);
            this.tabPage11.TabIndex = 0;
            this.tabPage11.Text = "Сотрудники";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(865, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 298);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список залов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзалаDataGridViewTextBoxColumn6,
            this.описаниезалаDataGridViewTextBoxColumn1,
            this.количествоместDataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.залBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(301, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерзалаDataGridViewTextBoxColumn6
            // 
            this.номерзалаDataGridViewTextBoxColumn6.DataPropertyName = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn6.HeaderText = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn6.Name = "номерзалаDataGridViewTextBoxColumn6";
            this.номерзалаDataGridViewTextBoxColumn6.ReadOnly = true;
            this.номерзалаDataGridViewTextBoxColumn6.Width = 96;
            // 
            // описаниезалаDataGridViewTextBoxColumn1
            // 
            this.описаниезалаDataGridViewTextBoxColumn1.DataPropertyName = "Описание_зала";
            this.описаниезалаDataGridViewTextBoxColumn1.HeaderText = "Описание_зала";
            this.описаниезалаDataGridViewTextBoxColumn1.Name = "описаниезалаDataGridViewTextBoxColumn1";
            this.описаниезалаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.описаниезалаDataGridViewTextBoxColumn1.Width = 112;
            // 
            // количествоместDataGridViewTextBoxColumn2
            // 
            this.количествоместDataGridViewTextBoxColumn2.DataPropertyName = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn2.HeaderText = "Количество_мест";
            this.количествоместDataGridViewTextBoxColumn2.Name = "количествоместDataGridViewTextBoxColumn2";
            this.количествоместDataGridViewTextBoxColumn2.ReadOnly = true;
            this.количествоместDataGridViewTextBoxColumn2.Width = 122;
            // 
            // grpWorkerHall
            // 
            this.grpWorkerHall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWorkerHall.Controls.Add(this.txtNamePostWorkerHall);
            this.grpWorkerHall.Controls.Add(this.lblNamePostWorkerHall);
            this.grpWorkerHall.Controls.Add(this.txtmPassportWorkerHall);
            this.grpWorkerHall.Controls.Add(this.btnUpdateWorkerHall);
            this.grpWorkerHall.Controls.Add(this.btnDeleteWorkerHall);
            this.grpWorkerHall.Controls.Add(this.btnAddWorkerHall);
            this.grpWorkerHall.Controls.Add(this.dgvwWorkerHall);
            this.grpWorkerHall.Controls.Add(this.lblPassportWorkerHall);
            this.grpWorkerHall.Controls.Add(this.txtNameWorkerHall);
            this.grpWorkerHall.Controls.Add(this.lblNameWorkerHall);
            this.grpWorkerHall.Controls.Add(this.txtNumHallWorkerHall);
            this.grpWorkerHall.Controls.Add(this.lblNumHallWorkerHall);
            this.grpWorkerHall.Location = new System.Drawing.Point(11, 327);
            this.grpWorkerHall.Name = "grpWorkerHall";
            this.grpWorkerHall.Size = new System.Drawing.Size(848, 298);
            this.grpWorkerHall.TabIndex = 51;
            this.grpWorkerHall.TabStop = false;
            this.grpWorkerHall.Text = "Сотрудники зала";
            // 
            // txtNamePostWorkerHall
            // 
            this.txtNamePostWorkerHall.CausesValidation = false;
            this.txtNamePostWorkerHall.Location = new System.Drawing.Point(4, 224);
            this.txtNamePostWorkerHall.Name = "txtNamePostWorkerHall";
            this.txtNamePostWorkerHall.Size = new System.Drawing.Size(213, 20);
            this.txtNamePostWorkerHall.TabIndex = 58;
            this.txtNamePostWorkerHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtNamePostWorkerHall_Validating);
            // 
            // lblNamePostWorkerHall
            // 
            this.lblNamePostWorkerHall.AutoSize = true;
            this.lblNamePostWorkerHall.Location = new System.Drawing.Point(3, 208);
            this.lblNamePostWorkerHall.Name = "lblNamePostWorkerHall";
            this.lblNamePostWorkerHall.Size = new System.Drawing.Size(115, 13);
            this.lblNamePostWorkerHall.TabIndex = 57;
            this.lblNamePostWorkerHall.Text = "Название должности";
            // 
            // txtmPassportWorkerHall
            // 
            this.txtmPassportWorkerHall.CausesValidation = false;
            this.txtmPassportWorkerHall.Location = new System.Drawing.Point(5, 160);
            this.txtmPassportWorkerHall.Mask = "0000000000";
            this.txtmPassportWorkerHall.Name = "txtmPassportWorkerHall";
            this.txtmPassportWorkerHall.Size = new System.Drawing.Size(212, 20);
            this.txtmPassportWorkerHall.TabIndex = 56;
            this.txtmPassportWorkerHall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmPassportWorkerHall_MouseClick);
            this.txtmPassportWorkerHall.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmPassportWorkerHall_KeyDown);
            this.txtmPassportWorkerHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtmPassportWorkerHall_Validating);
            // 
            // btnUpdateWorkerHall
            // 
            this.btnUpdateWorkerHall.Location = new System.Drawing.Point(85, 269);
            this.btnUpdateWorkerHall.Name = "btnUpdateWorkerHall";
            this.btnUpdateWorkerHall.Size = new System.Drawing.Size(65, 23);
            this.btnUpdateWorkerHall.TabIndex = 55;
            this.btnUpdateWorkerHall.Text = "Обновить";
            this.btnUpdateWorkerHall.UseVisualStyleBackColor = true;
            this.btnUpdateWorkerHall.Click += new System.EventHandler(this.btnUpdateWorkerHall_Click_1);
            // 
            // btnDeleteWorkerHall
            // 
            this.btnDeleteWorkerHall.Location = new System.Drawing.Point(157, 269);
            this.btnDeleteWorkerHall.Name = "btnDeleteWorkerHall";
            this.btnDeleteWorkerHall.Size = new System.Drawing.Size(65, 23);
            this.btnDeleteWorkerHall.TabIndex = 54;
            this.btnDeleteWorkerHall.Text = "Удалить";
            this.btnDeleteWorkerHall.UseVisualStyleBackColor = true;
            this.btnDeleteWorkerHall.Click += new System.EventHandler(this.btnDeleteWorkerHall_Click_1);
            // 
            // btnAddWorkerHall
            // 
            this.btnAddWorkerHall.Location = new System.Drawing.Point(4, 269);
            this.btnAddWorkerHall.Name = "btnAddWorkerHall";
            this.btnAddWorkerHall.Size = new System.Drawing.Size(76, 23);
            this.btnAddWorkerHall.TabIndex = 53;
            this.btnAddWorkerHall.Text = "Добавить";
            this.btnAddWorkerHall.UseVisualStyleBackColor = true;
            this.btnAddWorkerHall.Click += new System.EventHandler(this.btnAddWorkerHall_Click_1);
            // 
            // dgvwWorkerHall
            // 
            this.dgvwWorkerHall.AllowUserToAddRows = false;
            this.dgvwWorkerHall.AllowUserToDeleteRows = false;
            this.dgvwWorkerHall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwWorkerHall.AutoGenerateColumns = false;
            this.dgvwWorkerHall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwWorkerHall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwWorkerHall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзалаDataGridViewTextBoxColumn2,
            this.фИОсотрудникаDataGridViewTextBoxColumn3,
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn3,
            this.названиедолжностиDataGridViewTextBoxColumn3});
            this.dgvwWorkerHall.DataSource = this.сотрудникизалаBindingSource;
            this.dgvwWorkerHall.Location = new System.Drawing.Point(239, 19);
            this.dgvwWorkerHall.Name = "dgvwWorkerHall";
            this.dgvwWorkerHall.ReadOnly = true;
            this.dgvwWorkerHall.Size = new System.Drawing.Size(603, 273);
            this.dgvwWorkerHall.TabIndex = 52;
            this.dgvwWorkerHall.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwWorkerHall_CellClick);
            // 
            // номерзалаDataGridViewTextBoxColumn2
            // 
            this.номерзалаDataGridViewTextBoxColumn2.DataPropertyName = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn2.HeaderText = "Номер_зала";
            this.номерзалаDataGridViewTextBoxColumn2.Name = "номерзалаDataGridViewTextBoxColumn2";
            this.номерзалаDataGridViewTextBoxColumn2.ReadOnly = true;
            this.номерзалаDataGridViewTextBoxColumn2.Width = 96;
            // 
            // фИОсотрудникаDataGridViewTextBoxColumn3
            // 
            this.фИОсотрудникаDataGridViewTextBoxColumn3.DataPropertyName = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn3.HeaderText = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn3.Name = "фИОсотрудникаDataGridViewTextBoxColumn3";
            this.фИОсотрудникаDataGridViewTextBoxColumn3.ReadOnly = true;
            this.фИОсотрудникаDataGridViewTextBoxColumn3.Width = 123;
            // 
            // паспортныеданныесотрудникаDataGridViewTextBoxColumn3
            // 
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn3.DataPropertyName = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn3.HeaderText = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn3.Name = "паспортныеданныесотрудникаDataGridViewTextBoxColumn3";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn3.ReadOnly = true;
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn3.Width = 203;
            // 
            // названиедолжностиDataGridViewTextBoxColumn3
            // 
            this.названиедолжностиDataGridViewTextBoxColumn3.DataPropertyName = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn3.HeaderText = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn3.Name = "названиедолжностиDataGridViewTextBoxColumn3";
            this.названиедолжностиDataGridViewTextBoxColumn3.ReadOnly = true;
            this.названиедолжностиDataGridViewTextBoxColumn3.Width = 143;
            // 
            // сотрудникизалаBindingSource
            // 
            this.сотрудникизалаBindingSource.DataMember = "Сотрудники_зала";
            this.сотрудникизалаBindingSource.DataSource = this.workerHallDataSet;
            // 
            // workerHallDataSet
            // 
            this.workerHallDataSet.DataSetName = "WorkerHallDataSet";
            this.workerHallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPassportWorkerHall
            // 
            this.lblPassportWorkerHall.AutoSize = true;
            this.lblPassportWorkerHall.Location = new System.Drawing.Point(3, 144);
            this.lblPassportWorkerHall.Name = "lblPassportWorkerHall";
            this.lblPassportWorkerHall.Size = new System.Drawing.Size(111, 13);
            this.lblPassportWorkerHall.TabIndex = 50;
            this.lblPassportWorkerHall.Text = "Паспортные данные";
            // 
            // txtNameWorkerHall
            // 
            this.txtNameWorkerHall.CausesValidation = false;
            this.txtNameWorkerHall.Location = new System.Drawing.Point(6, 99);
            this.txtNameWorkerHall.Name = "txtNameWorkerHall";
            this.txtNameWorkerHall.Size = new System.Drawing.Size(211, 20);
            this.txtNameWorkerHall.TabIndex = 49;
            this.txtNameWorkerHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameWorkerHall_Validating);
            // 
            // lblNameWorkerHall
            // 
            this.lblNameWorkerHall.AutoSize = true;
            this.lblNameWorkerHall.Location = new System.Drawing.Point(4, 82);
            this.lblNameWorkerHall.Name = "lblNameWorkerHall";
            this.lblNameWorkerHall.Size = new System.Drawing.Size(95, 13);
            this.lblNameWorkerHall.TabIndex = 48;
            this.lblNameWorkerHall.Text = "ФИО сотрудника";
            // 
            // txtNumHallWorkerHall
            // 
            this.txtNumHallWorkerHall.CausesValidation = false;
            this.txtNumHallWorkerHall.Location = new System.Drawing.Point(6, 35);
            this.txtNumHallWorkerHall.Name = "txtNumHallWorkerHall";
            this.txtNumHallWorkerHall.Size = new System.Drawing.Size(211, 20);
            this.txtNumHallWorkerHall.TabIndex = 47;
            this.txtNumHallWorkerHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumHallWorkerHall_KeyPress_1);
            this.txtNumHallWorkerHall.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumHallWorkerHall_Validating);
            // 
            // lblNumHallWorkerHall
            // 
            this.lblNumHallWorkerHall.AutoSize = true;
            this.lblNumHallWorkerHall.Location = new System.Drawing.Point(2, 19);
            this.lblNumHallWorkerHall.Name = "lblNumHallWorkerHall";
            this.lblNumHallWorkerHall.Size = new System.Drawing.Size(68, 13);
            this.lblNumHallWorkerHall.TabIndex = 46;
            this.lblNumHallWorkerHall.Text = "Номер зала";
            // 
            // grpWorker
            // 
            this.grpWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpWorker.Controls.Add(this.txtmPassport);
            this.grpWorker.Controls.Add(this.txtTitlePostWorker);
            this.grpWorker.Controls.Add(this.txtmPhoneWorker);
            this.grpWorker.Controls.Add(this.dgvwWorker);
            this.grpWorker.Controls.Add(this.btnUpdateWorker);
            this.grpWorker.Controls.Add(this.btnDeleteWorker);
            this.grpWorker.Controls.Add(this.btnAddWorker);
            this.grpWorker.Controls.Add(this.txtAddress);
            this.grpWorker.Controls.Add(this.lblAddress);
            this.grpWorker.Controls.Add(this.lblPhoneWorker);
            this.grpWorker.Controls.Add(this.lblTitlePostWorker);
            this.grpWorker.Controls.Add(this.lblPassport);
            this.grpWorker.Controls.Add(this.txtNameWorker);
            this.grpWorker.Controls.Add(this.lblNameWorker);
            this.grpWorker.Location = new System.Drawing.Point(11, 6);
            this.grpWorker.Name = "grpWorker";
            this.grpWorker.Size = new System.Drawing.Size(1167, 315);
            this.grpWorker.TabIndex = 52;
            this.grpWorker.TabStop = false;
            this.grpWorker.Text = "Сотрудники";
            // 
            // txtmPassport
            // 
            this.txtmPassport.CausesValidation = false;
            this.txtmPassport.Location = new System.Drawing.Point(6, 86);
            this.txtmPassport.Mask = "0000000000";
            this.txtmPassport.Name = "txtmPassport";
            this.txtmPassport.RejectInputOnFirstFailure = true;
            this.txtmPassport.Size = new System.Drawing.Size(211, 20);
            this.txtmPassport.TabIndex = 64;
            this.txtmPassport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmPassport_MouseClick);
            this.txtmPassport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmPassport_KeyDown);
            this.txtmPassport.Validating += new System.ComponentModel.CancelEventHandler(this.txtmPassport_Validating);
            // 
            // txtTitlePostWorker
            // 
            this.txtTitlePostWorker.CausesValidation = false;
            this.txtTitlePostWorker.Location = new System.Drawing.Point(6, 141);
            this.txtTitlePostWorker.MaxLength = 50;
            this.txtTitlePostWorker.Name = "txtTitlePostWorker";
            this.txtTitlePostWorker.Size = new System.Drawing.Size(211, 20);
            this.txtTitlePostWorker.TabIndex = 63;
            this.txtTitlePostWorker.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitlePostWorker_Validating);
            // 
            // txtmPhoneWorker
            // 
            this.txtmPhoneWorker.CausesValidation = false;
            this.txtmPhoneWorker.Location = new System.Drawing.Point(6, 192);
            this.txtmPhoneWorker.Mask = "+70000000000";
            this.txtmPhoneWorker.Name = "txtmPhoneWorker";
            this.txtmPhoneWorker.Size = new System.Drawing.Size(211, 20);
            this.txtmPhoneWorker.TabIndex = 62;
            this.txtmPhoneWorker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtmPhoneWorker_MouseClick);
            this.txtmPhoneWorker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmPhoneWorker_KeyDown);
            this.txtmPhoneWorker.Validating += new System.ComponentModel.CancelEventHandler(this.txtmPhoneWorker_Validating);
            // 
            // dgvwWorker
            // 
            this.dgvwWorker.AllowUserToAddRows = false;
            this.dgvwWorker.AllowUserToDeleteRows = false;
            this.dgvwWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwWorker.AutoGenerateColumns = false;
            this.dgvwWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОсотрудникаDataGridViewTextBoxColumn1,
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn1,
            this.названиедолжностиDataGridViewTextBoxColumn1,
            this.номертелефонасотрудникаDataGridViewTextBoxColumn,
            this.адрессотрудникаDataGridViewTextBoxColumn});
            this.dgvwWorker.DataSource = this.сотрудникBindingSource;
            this.dgvwWorker.Location = new System.Drawing.Point(239, 19);
            this.dgvwWorker.Name = "dgvwWorker";
            this.dgvwWorker.ReadOnly = true;
            this.dgvwWorker.Size = new System.Drawing.Size(922, 286);
            this.dgvwWorker.TabIndex = 61;
            this.dgvwWorker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwWorker_CellClick_1);
            // 
            // фИОсотрудникаDataGridViewTextBoxColumn1
            // 
            this.фИОсотрудникаDataGridViewTextBoxColumn1.DataPropertyName = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn1.HeaderText = "ФИО_сотрудника";
            this.фИОсотрудникаDataGridViewTextBoxColumn1.Name = "фИОсотрудникаDataGridViewTextBoxColumn1";
            this.фИОсотрудникаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.фИОсотрудникаDataGridViewTextBoxColumn1.Width = 123;
            // 
            // паспортныеданныесотрудникаDataGridViewTextBoxColumn1
            // 
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn1.DataPropertyName = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn1.HeaderText = "Паспортные_данные_сотрудника";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn1.Name = "паспортныеданныесотрудникаDataGridViewTextBoxColumn1";
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.паспортныеданныесотрудникаDataGridViewTextBoxColumn1.Width = 203;
            // 
            // названиедолжностиDataGridViewTextBoxColumn1
            // 
            this.названиедолжностиDataGridViewTextBoxColumn1.DataPropertyName = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn1.HeaderText = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn1.Name = "названиедолжностиDataGridViewTextBoxColumn1";
            this.названиедолжностиDataGridViewTextBoxColumn1.ReadOnly = true;
            this.названиедолжностиDataGridViewTextBoxColumn1.Width = 143;
            // 
            // номертелефонасотрудникаDataGridViewTextBoxColumn
            // 
            this.номертелефонасотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона_сотрудника";
            this.номертелефонасотрудникаDataGridViewTextBoxColumn.HeaderText = "Номер_телефона_сотрудника";
            this.номертелефонасотрудникаDataGridViewTextBoxColumn.Name = "номертелефонасотрудникаDataGridViewTextBoxColumn";
            this.номертелефонасотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номертелефонасотрудникаDataGridViewTextBoxColumn.Width = 185;
            // 
            // адрессотрудникаDataGridViewTextBoxColumn
            // 
            this.адрессотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Адрес_сотрудника";
            this.адрессотрудникаDataGridViewTextBoxColumn.HeaderText = "Адрес_сотрудника";
            this.адрессотрудникаDataGridViewTextBoxColumn.Name = "адрессотрудникаDataGridViewTextBoxColumn";
            this.адрессотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.адрессотрудникаDataGridViewTextBoxColumn.Width = 127;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.workerDataSet;
            // 
            // workerDataSet
            // 
            this.workerDataSet.DataSetName = "WorkerDataSet";
            this.workerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdateWorker
            // 
            this.btnUpdateWorker.Location = new System.Drawing.Point(81, 282);
            this.btnUpdateWorker.Name = "btnUpdateWorker";
            this.btnUpdateWorker.Size = new System.Drawing.Size(64, 23);
            this.btnUpdateWorker.TabIndex = 60;
            this.btnUpdateWorker.Text = "Обновить";
            this.btnUpdateWorker.UseVisualStyleBackColor = true;
            this.btnUpdateWorker.Click += new System.EventHandler(this.btnUpdateWorker_Click_1);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.Location = new System.Drawing.Point(151, 282);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(66, 23);
            this.btnDeleteWorker.TabIndex = 59;
            this.btnDeleteWorker.Text = "Удалить";
            this.btnDeleteWorker.UseVisualStyleBackColor = true;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click_1);
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(6, 282);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(69, 23);
            this.btnAddWorker.TabIndex = 58;
            this.btnAddWorker.Text = "Добавить";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click_1);
            // 
            // txtAddress
            // 
            this.txtAddress.CausesValidation = false;
            this.txtAddress.Location = new System.Drawing.Point(6, 247);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(211, 20);
            this.txtAddress.TabIndex = 57;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 231);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 56;
            this.lblAddress.Text = "Адрес";
            // 
            // lblPhoneWorker
            // 
            this.lblPhoneWorker.AutoSize = true;
            this.lblPhoneWorker.Location = new System.Drawing.Point(3, 176);
            this.lblPhoneWorker.Name = "lblPhoneWorker";
            this.lblPhoneWorker.Size = new System.Drawing.Size(93, 13);
            this.lblPhoneWorker.TabIndex = 55;
            this.lblPhoneWorker.Text = "Номер телефона";
            // 
            // lblTitlePostWorker
            // 
            this.lblTitlePostWorker.AutoSize = true;
            this.lblTitlePostWorker.Location = new System.Drawing.Point(3, 125);
            this.lblTitlePostWorker.Name = "lblTitlePostWorker";
            this.lblTitlePostWorker.Size = new System.Drawing.Size(115, 13);
            this.lblTitlePostWorker.TabIndex = 54;
            this.lblTitlePostWorker.Text = "Название должности";
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Location = new System.Drawing.Point(3, 70);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(111, 13);
            this.lblPassport.TabIndex = 53;
            this.lblPassport.Text = "Паспортные данные";
            // 
            // txtNameWorker
            // 
            this.txtNameWorker.CausesValidation = false;
            this.txtNameWorker.Location = new System.Drawing.Point(6, 35);
            this.txtNameWorker.MaxLength = 50;
            this.txtNameWorker.Name = "txtNameWorker";
            this.txtNameWorker.Size = new System.Drawing.Size(211, 20);
            this.txtNameWorker.TabIndex = 52;
            this.txtNameWorker.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameWorker_Validating);
            // 
            // lblNameWorker
            // 
            this.lblNameWorker.AutoSize = true;
            this.lblNameWorker.Location = new System.Drawing.Point(3, 19);
            this.lblNameWorker.Name = "lblNameWorker";
            this.lblNameWorker.Size = new System.Drawing.Size(95, 13);
            this.lblNameWorker.TabIndex = 51;
            this.lblNameWorker.Text = "ФИО сотрудника";
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.dgvwPost);
            this.tabPage12.Controls.Add(this.txtDescriptionPost);
            this.tabPage12.Controls.Add(this.txtTitlePost);
            this.tabPage12.Controls.Add(this.txtSalary);
            this.tabPage12.Controls.Add(this.btnUpdatePost);
            this.tabPage12.Controls.Add(this.lblTitlePost);
            this.tabPage12.Controls.Add(this.lblDescriptionPost);
            this.tabPage12.Controls.Add(this.lblSalary);
            this.tabPage12.Controls.Add(this.btnDeletePost);
            this.tabPage12.Controls.Add(this.btnAddPost);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1184, 631);
            this.tabPage12.TabIndex = 1;
            this.tabPage12.Text = "Должность";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // dgvwPost
            // 
            this.dgvwPost.AllowUserToAddRows = false;
            this.dgvwPost.AllowUserToDeleteRows = false;
            this.dgvwPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwPost.AutoGenerateColumns = false;
            this.dgvwPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvwPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиедолжностиDataGridViewTextBoxColumn4,
            this.описаниедолжностиDataGridViewTextBoxColumn,
            this.зарплатаDataGridViewTextBoxColumn});
            this.dgvwPost.DataSource = this.должностьBindingSource1;
            this.dgvwPost.Location = new System.Drawing.Point(252, 6);
            this.dgvwPost.Name = "dgvwPost";
            this.dgvwPost.ReadOnly = true;
            this.dgvwPost.Size = new System.Drawing.Size(929, 619);
            this.dgvwPost.TabIndex = 44;
            this.dgvwPost.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwPost_CellClick);
            // 
            // названиедолжностиDataGridViewTextBoxColumn4
            // 
            this.названиедолжностиDataGridViewTextBoxColumn4.DataPropertyName = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn4.HeaderText = "Название_должности";
            this.названиедолжностиDataGridViewTextBoxColumn4.Name = "названиедолжностиDataGridViewTextBoxColumn4";
            this.названиедолжностиDataGridViewTextBoxColumn4.ReadOnly = true;
            this.названиедолжностиDataGridViewTextBoxColumn4.Width = 143;
            // 
            // описаниедолжностиDataGridViewTextBoxColumn
            // 
            this.описаниедолжностиDataGridViewTextBoxColumn.DataPropertyName = "Описание_должности";
            this.описаниедолжностиDataGridViewTextBoxColumn.HeaderText = "Описание_должности";
            this.описаниедолжностиDataGridViewTextBoxColumn.Name = "описаниедолжностиDataGridViewTextBoxColumn";
            this.описаниедолжностиDataGridViewTextBoxColumn.ReadOnly = true;
            this.описаниедолжностиDataGridViewTextBoxColumn.Width = 143;
            // 
            // зарплатаDataGridViewTextBoxColumn
            // 
            this.зарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.Name = "зарплатаDataGridViewTextBoxColumn";
            this.зарплатаDataGridViewTextBoxColumn.ReadOnly = true;
            this.зарплатаDataGridViewTextBoxColumn.Width = 80;
            // 
            // должностьBindingSource1
            // 
            this.должностьBindingSource1.DataMember = "Должность";
            this.должностьBindingSource1.DataSource = this.postDataSet;
            // 
            // postDataSet
            // 
            this.postDataSet.DataSetName = "PostDataSet";
            this.postDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDescriptionPost
            // 
            this.txtDescriptionPost.CausesValidation = false;
            this.txtDescriptionPost.Location = new System.Drawing.Point(9, 92);
            this.txtDescriptionPost.MaxLength = 50;
            this.txtDescriptionPost.Name = "txtDescriptionPost";
            this.txtDescriptionPost.Size = new System.Drawing.Size(221, 20);
            this.txtDescriptionPost.TabIndex = 43;
            this.txtDescriptionPost.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescriptionPost_Validating);
            // 
            // txtTitlePost
            // 
            this.txtTitlePost.CausesValidation = false;
            this.txtTitlePost.Location = new System.Drawing.Point(9, 29);
            this.txtTitlePost.MaxLength = 50;
            this.txtTitlePost.Name = "txtTitlePost";
            this.txtTitlePost.Size = new System.Drawing.Size(221, 20);
            this.txtTitlePost.TabIndex = 34;
            this.txtTitlePost.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitlePost_Validating);
            // 
            // txtSalary
            // 
            this.txtSalary.CausesValidation = false;
            this.txtSalary.Location = new System.Drawing.Point(9, 159);
            this.txtSalary.MaxLength = 10;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(221, 20);
            this.txtSalary.TabIndex = 39;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // btnUpdatePost
            // 
            this.btnUpdatePost.Location = new System.Drawing.Point(86, 198);
            this.btnUpdatePost.Name = "btnUpdatePost";
            this.btnUpdatePost.Size = new System.Drawing.Size(73, 23);
            this.btnUpdatePost.TabIndex = 41;
            this.btnUpdatePost.Text = "Обновить";
            this.btnUpdatePost.UseVisualStyleBackColor = true;
            this.btnUpdatePost.Click += new System.EventHandler(this.btnUpdatePost_Click);
            // 
            // lblTitlePost
            // 
            this.lblTitlePost.AutoSize = true;
            this.lblTitlePost.Location = new System.Drawing.Point(6, 13);
            this.lblTitlePost.Name = "lblTitlePost";
            this.lblTitlePost.Size = new System.Drawing.Size(115, 13);
            this.lblTitlePost.TabIndex = 33;
            this.lblTitlePost.Text = "Название должности";
            // 
            // lblDescriptionPost
            // 
            this.lblDescriptionPost.AutoSize = true;
            this.lblDescriptionPost.Location = new System.Drawing.Point(6, 76);
            this.lblDescriptionPost.Name = "lblDescriptionPost";
            this.lblDescriptionPost.Size = new System.Drawing.Size(115, 13);
            this.lblDescriptionPost.TabIndex = 35;
            this.lblDescriptionPost.Text = "Описание должности";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(6, 143);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(55, 13);
            this.lblSalary.TabIndex = 36;
            this.lblSalary.Text = "Зарплата";
            // 
            // btnDeletePost
            // 
            this.btnDeletePost.Location = new System.Drawing.Point(165, 198);
            this.btnDeletePost.Name = "btnDeletePost";
            this.btnDeletePost.Size = new System.Drawing.Size(65, 23);
            this.btnDeletePost.TabIndex = 38;
            this.btnDeletePost.Text = "Удалить";
            this.btnDeletePost.UseVisualStyleBackColor = true;
            this.btnDeletePost.Click += new System.EventHandler(this.btnDeletePost_Click);
            // 
            // btnAddPost
            // 
            this.btnAddPost.Location = new System.Drawing.Point(9, 198);
            this.btnAddPost.Name = "btnAddPost";
            this.btnAddPost.Size = new System.Drawing.Size(71, 23);
            this.btnAddPost.TabIndex = 37;
            this.btnAddPost.Text = "Добавить";
            this.btnAddPost.UseVisualStyleBackColor = true;
            this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.reportViewer2);
            this.tabPage18.Location = new System.Drawing.Point(4, 22);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage18.Size = new System.Drawing.Size(1184, 631);
            this.tabPage18.TabIndex = 3;
            this.tabPage18.Text = "Отчет о кассирах";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource90.Name = "TopCashier";
            reportDataSource90.Value = this.Топ_кассировBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource90);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Cinema.TopCashier.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1178, 625);
            this.reportViewer2.TabIndex = 0;
            // 
            // топфильмовBindingSource
            // 
            this.топфильмовBindingSource.DataMember = "Топ_фильмов";
            this.топфильмовBindingSource.DataSource = this.topFilmDataSet;
            // 
            // залыбезфильмовBindingSource
            // 
            this.залыбезфильмовBindingSource.DataMember = "Залы_без_фильмов";
            this.залыбезфильмовBindingSource.DataSource = this.hallWithoutFilmDataSet;
            // 
            // колбилетовзалаBindingSource
            // 
            this.колбилетовзалаBindingSource.DataMember = "Кол_билетов_зала";
            this.колбилетовзалаBindingSource.DataSource = this.countOfTicketDataSet;
            // 
            // топклиентовBindingSource
            // 
            this.топклиентовBindingSource.DataMember = "Топ_клиентов";
            this.топклиентовBindingSource.DataSource = this.topClientDataSet;
            // 
            // топкассировBindingSource
            // 
            this.топкассировBindingSource.DataMember = "Топ_кассиров";
            this.топкассировBindingSource.DataSource = this.topCashierDataSet;
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.postTitleDataSet;
            // 
            // postTitleDataSet
            // 
            this.postTitleDataSet.DataSetName = "PostTitleDataSet";
            this.postTitleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // залBindingSource1
            // 
            this.залBindingSource1.DataMember = "Зал";
            this.залBindingSource1.DataSource = this.hallNumberDataSet;
            // 
            // hallNumberDataSet
            // 
            this.hallNumberDataSet.DataSetName = "HallNumberDataSet";
            this.hallNumberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // приобретение_лицензииTableAdapter
            // 
            this.приобретение_лицензииTableAdapter.ClearBeforeFill = true;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // залTableAdapter
            // 
            this.залTableAdapter.ClearBeforeFill = true;
            // 
            // места_в_залеTableAdapter
            // 
            this.места_в_залеTableAdapter.ClearBeforeFill = true;
            // 
            // залTableAdapter1
            // 
            this.залTableAdapter1.ClearBeforeFill = true;
            // 
            // сотрудникTableAdapter1
            // 
            this.сотрудникTableAdapter1.ClearBeforeFill = true;
            // 
            // фильмTableAdapter
            // 
            this.фильмTableAdapter.ClearBeforeFill = true;
            // 
            // сеансTableAdapter
            // 
            this.сеансTableAdapter.ClearBeforeFill = true;
            // 
            // сеансы_залаTableAdapter
            // 
            this.сеансы_залаTableAdapter.ClearBeforeFill = true;
            // 
            // лицензияTableAdapter
            // 
            this.лицензияTableAdapter.ClearBeforeFill = true;
            // 
            // показ_фильмаTableAdapter
            // 
            this.показ_фильмаTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудники_залаTableAdapter
            // 
            this.сотрудники_залаTableAdapter.ClearBeforeFill = true;
            // 
            // показывает_фильмTableAdapter
            // 
            this.показывает_фильмTableAdapter.ClearBeforeFill = true;
            // 
            // должностьTableAdapter1
            // 
            this.должностьTableAdapter1.ClearBeforeFill = true;
            // 
            // топ_кассировTableAdapter
            // 
            this.топ_кассировTableAdapter.ClearBeforeFill = true;
            // 
            // топ_клиентовTableAdapter
            // 
            this.топ_клиентовTableAdapter.ClearBeforeFill = true;
            // 
            // топ_фильмовTableAdapter
            // 
            this.топ_фильмовTableAdapter.ClearBeforeFill = true;
            // 
            // залы_без_фильмовTableAdapter
            // 
            this.залы_без_фильмовTableAdapter.ClearBeforeFill = true;
            // 
            // кол_билетов_залаTableAdapter
            // 
            this.кол_билетов_залаTableAdapter.ClearBeforeFill = true;
            // 
            // билетTableAdapter
            // 
            this.билетTableAdapter.ClearBeforeFill = true;
            // 
            // продажа_билетовTableAdapter
            // 
            this.продажа_билетовTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // hallNumberDataSet1
            // 
            this.hallNumberDataSet1.DataSetName = "HallNumberDataSet";
            this.hallNumberDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hallNumberDataSet2
            // 
            this.hallNumberDataSet2.DataSetName = "HallNumberDataSet";
            this.hallNumberDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1206, 689);
            this.Controls.Add(this.tabWorker);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Топ_фильмовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Залы_без_фильмовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallWithoutFilmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Кол_билетов_залаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countOfTicketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Топ_клиентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topClientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Продажа_билетовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldTicketsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Топ_кассировBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCashierDataSet)).EndInit();
            this.tabWorker.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tabFilm.ResumeLayout(false);
            this.tabFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmDataSet)).EndInit();
            this.tabSession.ResumeLayout(false);
            this.grpSession.ResumeLayout(false);
            this.grpSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionDataSet)).EndInit();
            this.grpSessionHall.ResumeLayout(false);
            this.grpSessionHall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearSessionHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSessionHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансызалаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionInHallDataSet)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.grpShowFilm.ResumeLayout(false);
            this.grpShowFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFilmShowFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwShowFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.показываетфильмBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFilmDataSet)).EndInit();
            this.grpPlaceHall.ResumeLayout(false);
            this.grpAddGroupPlaceHall.ResumeLayout(false);
            this.grpAddGroupPlaceHall.PerformLayout();
            this.grpAddPlaceHall.ResumeLayout(false);
            this.grpAddPlaceHall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwPlaceHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.меставзалеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeInHallDataSet)).EndInit();
            this.grpHall.ResumeLayout(false);
            this.grpHall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallDataSet)).EndInit();
            this.tabPage15.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.tabPage17.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabCashier.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.grpTicketPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTicket)).EndInit();
            this.grpSoldTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSoldTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажабилетовBindingSource)).EndInit();
            this.grpSellTicket.ResumeLayout(false);
            this.grpSellTicket.PerformLayout();
            this.grpHallLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwHallTicket)).EndInit();
            this.grpSellTicketPlace.ResumeLayout(false);
            this.grpSellTicketPlace.PerformLayout();
            this.grpTicket.ResumeLayout(false);
            this.grpTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataSet)).EndInit();
            this.tabPage14.ResumeLayout(false);
            this.tabReportTicket.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.grpLicense.ResumeLayout(false);
            this.grpLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лицензияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lisenseListDataSet)).EndInit();
            this.grpAcquisitionLicense.ResumeLayout(false);
            this.grpAcquisitionLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFilmAcquisitionLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAcquisitionLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приобретениелицензииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.grpShowingFilm.ResumeLayout(false);
            this.grpShowingFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYearFilmShowing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwShowingFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.показфильмаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showingFilmDataSet)).EndInit();
            this.grpEquipment.ResumeLayout(false);
            this.grpEquipment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataSet)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpWorkerHall.ResumeLayout(false);
            this.grpWorkerHall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWorkerHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникизалаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerHallDataSet)).EndInit();
            this.grpWorker.ResumeLayout(false);
            this.grpWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataSet)).EndInit();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).EndInit();
            this.tabPage18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.топфильмовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыбезфильмовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.колбилетовзалаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.топклиентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.топкассировBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postTitleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallNumberDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallNumberDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallNumberDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabWorker;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabCashier;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvwClient;
        private System.Windows.Forms.ComboBox cboTypeClient;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiscountCard;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiscountCard;
        private System.Windows.Forms.Label lblTypeClient;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnAddClient;
        private ClientDataSet clientDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private ClientDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидочнаякартаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteAcquisitionLicense;
        private System.Windows.Forms.Button btnAddAcquisitionLicense;
        private System.Windows.Forms.Label lblPassportWorkerAcquisitionLicense;
        private System.Windows.Forms.Label lblNameWorkerAcquisitionLicense;
        private System.Windows.Forms.Label lblYearFilmAcquisitionLicense;
        private System.Windows.Forms.Label lblNameFilmAcquisitionLicense;
        private System.Windows.Forms.TextBox txtNumAcquisitionLicense;
        private System.Windows.Forms.Label lblNumAcquisitionLicense;
        private System.Windows.Forms.TextBox txtNameWorkerAcquisitionLicense;
        private LicenseDataSet licenseDataSet;
        private System.Windows.Forms.BindingSource приобретениелицензииBindingSource;
        private LicenseDataSetTableAdapters.Приобретение_лицензииTableAdapter приобретение_лицензииTableAdapter;
        private System.Windows.Forms.TextBox txtNameFilmAcquisitionLicense;
        private System.Windows.Forms.TextBox txtDescriptionEquipment;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Label lblTitleEquipment;
        private System.Windows.Forms.Label lblEquipmentFormat;
        private System.Windows.Forms.TextBox txtEquipmentID;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.ComboBox cboEquipmentFormat;
        private EquipmentDataSet equipmentDataSet;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private EquipmentDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private PostTitleDataSet postTitleDataSet;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private PostTitleDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private WorkerDataSet workerDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private WorkerDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private HallDataSet hallDataSet;
        private System.Windows.Forms.BindingSource залBindingSource;
        private HallDataSetTableAdapters.ЗалTableAdapter залTableAdapter;
        private PlaceInHallDataSet placeInHallDataSet;
        private System.Windows.Forms.BindingSource меставзалеBindingSource;
        private PlaceInHallDataSetTableAdapters.Места_в_залеTableAdapter места_в_залеTableAdapter;
        private HallNumberDataSet hallNumberDataSet;
        private System.Windows.Forms.BindingSource залBindingSource1;
        private HallNumberDataSetTableAdapters.ЗалTableAdapter залTableAdapter1;
        private EmployeeNameDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter1;
        private FilmDataSet filmDataSet;
        private System.Windows.Forms.BindingSource фильмBindingSource;
        private FilmDataSetTableAdapters.ФильмTableAdapter фильмTableAdapter;
        private SessionDataSet sessionDataSet;
        private System.Windows.Forms.BindingSource сеансBindingSource;
        private SessionDataSetTableAdapters.СеансTableAdapter сеансTableAdapter;
        private SessionInHallDataSet sessionInHallDataSet;
        private System.Windows.Forms.BindingSource сеансызалаBindingSource;
        private SessionInHallDataSetTableAdapters.Сеансы_залаTableAdapter сеансы_залаTableAdapter;
        private LisenseListDataSet lisenseListDataSet;
        private System.Windows.Forms.BindingSource лицензияBindingSource;
        private LisenseListDataSetTableAdapters.ЛицензияTableAdapter лицензияTableAdapter;
        private System.Windows.Forms.GroupBox grpLicense;
        private System.Windows.Forms.TextBox txtNumLicense;
        private System.Windows.Forms.Label lblNumLicense;
        private System.Windows.Forms.Button btnDeleteLicense;
        private System.Windows.Forms.Button btnUpdateLicense;
        private System.Windows.Forms.Button btnAddLicense;
        private System.Windows.Forms.TextBox txtDescriptionLicense;
        private System.Windows.Forms.Label lblCostLicense;
        private System.Windows.Forms.Label lblDescriptionLicense;
        private System.Windows.Forms.Label lblValidityLicense;
        private System.Windows.Forms.GroupBox grpAcquisitionLicense;
        private System.Windows.Forms.GroupBox grpShowingFilm;
        private System.Windows.Forms.GroupBox grpEquipment;
        private ShowingFilmDataSet showingFilmDataSet;
        private System.Windows.Forms.BindingSource показфильмаBindingSource;
        private ShowingFilmDataSetTableAdapters.Показ_фильмаTableAdapter показ_фильмаTableAdapter;
        private System.Windows.Forms.Button btnDeleteShowingFilm;
        private System.Windows.Forms.Button btnAddShowingFilm;
        private System.Windows.Forms.Label lblPassportShowing;
        private System.Windows.Forms.TextBox txtNameWorkerShowing;
        private System.Windows.Forms.Label lblNameWorkerShowing;
        private System.Windows.Forms.TextBox txtNameFilmShowing;
        private System.Windows.Forms.Label lblNameFilmShowing;
        private System.Windows.Forms.Label lblYearFilmShowing;
        private System.Windows.Forms.TextBox txtEquipmentIDFilm;
        private System.Windows.Forms.Label lblEquipmentIDFilm;
        private System.Windows.Forms.DataGridView dgvwAcquisitionLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерлицензииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годвыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеданныесотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиедолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvwLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерлицензииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьлицензииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниелицензииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сроклицензииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvwShowingFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDоборудованияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn годвыпускаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОсотрудникаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеданныесотрудникаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиедолжностиDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvwEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDоборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn форматоборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеоборудованияDataGridViewTextBoxColumn;
        private WorkerHallDataSet workerHallDataSet;
        private System.Windows.Forms.BindingSource сотрудникизалаBindingSource;
        private WorkerHallDataSetTableAdapters.Сотрудники_залаTableAdapter сотрудники_залаTableAdapter;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabFilm;
        private System.Windows.Forms.Button btnUpdateFilm;
        private System.Windows.Forms.Button btnDeleteFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.DataGridView dgvwFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn годвыпускаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn режиссёрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn форматDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рейтингDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboRating;
        private System.Windows.Forms.ComboBox cboFormatFilm;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.TextBox txtNameFilm;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblFormatFilm;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblNameFilm;
        private System.Windows.Forms.Label lblYearFilm;
        private System.Windows.Forms.TabPage tabSession;
        private System.Windows.Forms.GroupBox grpSession;
        private System.Windows.Forms.DataGridView dgvwSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn времясеансаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn годвыпускаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblTimeSession;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.Button btnUpdateSession;
        private System.Windows.Forms.Label lblNameFilmSession;
        private System.Windows.Forms.TextBox txtNameFilmSession;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Label lblYearFilmSession;
        private System.Windows.Forms.GroupBox grpSessionHall;
        private System.Windows.Forms.DataGridView dgvwSessionHall;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtNumHallSessionHall;
        private System.Windows.Forms.Label lblTimeSessionHall;
        private System.Windows.Forms.Button btnDeleteSessionHall;
        private System.Windows.Forms.Label lblNumHallSessionHall;
        private System.Windows.Forms.Button btnAddSessionHall;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.GroupBox grpShowFilm;
        private System.Windows.Forms.GroupBox grpPlaceHall;
        private System.Windows.Forms.GroupBox grpAddGroupPlaceHall;
        private System.Windows.Forms.TextBox txtGroupNumHallPlace;
        private System.Windows.Forms.TextBox txtGroupQuantityPlaceHall;
        private System.Windows.Forms.TextBox txtGroupNumRowHallPlace;
        private System.Windows.Forms.Button btnAddGroupPlaceHall;
        private System.Windows.Forms.Label lblGroupQuantityPlaceHall;
        private System.Windows.Forms.Label lblGroupNumRowHallPlace;
        private System.Windows.Forms.Label lblGroupNumHallPlace;
        private System.Windows.Forms.GroupBox grpAddPlaceHall;
        private System.Windows.Forms.TextBox txtNumHallPlaceHall;
        private System.Windows.Forms.Button btnDeletePlaceHall;
        private System.Windows.Forms.TextBox txtNumPlaceHall;
        private System.Windows.Forms.TextBox txtNumRowPlaceHall;
        private System.Windows.Forms.Button btnAddPlaceHall;
        private System.Windows.Forms.Label lblNumPlaceHall;
        private System.Windows.Forms.Label lblNumRowPlaceHall;
        private System.Windows.Forms.Label lblNumHallPlaceHall;
        private System.Windows.Forms.DataGridView dgvwPlaceHall;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерместаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеррядаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзалаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox grpHall;
        private System.Windows.Forms.TextBox txtDescriptionHall;
        private System.Windows.Forms.TextBox txtQuantityPlaceHall;
        private System.Windows.Forms.TextBox txtNumHall;
        private System.Windows.Forms.Button btnUpdateHall;
        private System.Windows.Forms.Button btnDeleteHall;
        private System.Windows.Forms.Button btnAddHall;
        private System.Windows.Forms.Label lblQuantityPlaceHall;
        private System.Windows.Forms.Label lblDescriptionHall;
        private System.Windows.Forms.Label lblNumHall;
        private System.Windows.Forms.DataGridView dgvwHall;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниезалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоместDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvwShowFilm;
        private System.Windows.Forms.TextBox txtNameFilmShowFilm;
        private System.Windows.Forms.Label lblNameFilmShowFilm;
        private System.Windows.Forms.Label lblYearFilmShowFilm;
        private System.Windows.Forms.TextBox txtNumHallShowFilm;
        private System.Windows.Forms.Label lblNumHallShowFilm;
        private ShowFilmDataSet showFilmDataSet;
        private System.Windows.Forms.BindingSource показываетфильмBindingSource;
        private ShowFilmDataSetTableAdapters.Показывает_фильмTableAdapter показывает_фильмTableAdapter;
        private System.Windows.Forms.Button btnDeleteShowFilm;
        private System.Windows.Forms.Button btnAddShowFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзалаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn годвыпускаDataGridViewTextBoxColumn4;
        private PostDataSet postDataSet;
        private System.Windows.Forms.BindingSource должностьBindingSource1;
        private PostDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter1;
        private TopCashierDataSet topCashierDataSet;
        private System.Windows.Forms.BindingSource топкассировBindingSource;
        private TopCashierDataSetTableAdapters.Топ_кассировTableAdapter топ_кассировTableAdapter;
        private System.Windows.Forms.TabPage tabPage14;
        private TopClientDataSet topClientDataSet;
        private System.Windows.Forms.BindingSource топклиентовBindingSource;
        private TopClientDataSetTableAdapters.Топ_клиентовTableAdapter топ_клиентовTableAdapter;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.TabPage tabPage16;
        private TopFilmDataSet topFilmDataSet;
        private System.Windows.Forms.BindingSource топфильмовBindingSource;
        private TopFilmDataSetTableAdapters.Топ_фильмовTableAdapter топ_фильмовTableAdapter;
        private HallWithoutFilmDataSet hallWithoutFilmDataSet;
        private System.Windows.Forms.BindingSource залыбезфильмовBindingSource;
        private HallWithoutFilmDataSetTableAdapters.Залы_без_фильмовTableAdapter залы_без_фильмовTableAdapter;
        private System.Windows.Forms.TabPage tabPage17;
        private CountOfTicketDataSet countOfTicketDataSet;
        private System.Windows.Forms.BindingSource колбилетовзалаBindingSource;
        private CountOfTicketDataSetTableAdapters.Кол_билетов_залаTableAdapter кол_билетов_залаTableAdapter;
        private System.Windows.Forms.TextBox txtTitlePostShowing;
        private System.Windows.Forms.Label lblTitlePostShowing;
        private System.Windows.Forms.TextBox txtCostLicense;
        private System.Windows.Forms.TextBox txtTitlePostAcquisitionLicense;
        private System.Windows.Forms.Label lblTitlePostAcquisitionLicense;
        private System.Windows.Forms.MaskedTextBox txtmPassportShowing;
        private System.Windows.Forms.MaskedTextBox txtmPassportWorkerAcquisitionLicense;
        private System.Windows.Forms.MaskedTextBox txtmPhone;
        private System.Windows.Forms.DateTimePicker dtmTimeSession;
        private System.Windows.Forms.DateTimePicker dtmTimeSessionHall;
        private System.Windows.Forms.Label lblNameFilmSessionHall;
        private System.Windows.Forms.TextBox txtNameFilmSessionHall;
        private System.Windows.Forms.Label lblYearFilmSessionHall;
        private System.Windows.Forms.ComboBox cboRatingFilmShowsFilm;
        private System.Windows.Forms.ComboBox cboFormatFilmShowsFilm;
        private System.Windows.Forms.TextBox txtGenreShowsFilm;
        private System.Windows.Forms.TextBox txtProducerShowsFilm;
        private System.Windows.Forms.Label lblRatingFilmShowsFilm;
        private System.Windows.Forms.Label lblFormatFilmShowsFilm;
        private System.Windows.Forms.Label lblGenreShowsFilm;
        private System.Windows.Forms.Label lblProducerShowsFilm;
        private System.Windows.Forms.GroupBox grpTicket;
        private System.Windows.Forms.DataGridView dgvwTicket;
        private TicketDataSet ticketDataSet;
        private System.Windows.Forms.BindingSource билетBindingSource;
        private TicketDataSetTableAdapters.БилетTableAdapter билетTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номербилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценабилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаивремяпродажибилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grpSellTicket;
        private System.Windows.Forms.ComboBox cboDateSessionTicket;
        private System.Windows.Forms.ComboBox cboNameFilmTicket;
        private System.Windows.Forms.Label lblDateSessionTicket;
        private System.Windows.Forms.Label lblNameFilmTicket;
        private System.Windows.Forms.Button btnShowFilmTicket;
        private System.Windows.Forms.ComboBox cboNumHallTicket;
        private System.Windows.Forms.Label lblNumHallTicket;
        private System.Windows.Forms.GroupBox grpSellTicketPlace;
        private System.Windows.Forms.Label lblRowSellTicket;
        private System.Windows.Forms.Label lblPlaceSellTicket;
        private System.Windows.Forms.MaskedTextBox txtmPassportWorkerTicket;
        private System.Windows.Forms.MaskedTextBox txtmPhoneClientTicket;
        private System.Windows.Forms.TextBox txtNameWorkerTicket;
        private System.Windows.Forms.TextBox txtNameClientTicket;
        private System.Windows.Forms.Label lblPhoneClientTicket;
        private System.Windows.Forms.Label lblNameWorkerTicket;
        private System.Windows.Forms.Label lblPassportWorkerTicket;
        private System.Windows.Forms.Label lblNameClientTicket;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.MaskedTextBox txtmCostTicket;
        private System.Windows.Forms.TextBox txtNumTicket;
        private System.Windows.Forms.Label lblCostTicket;
        private System.Windows.Forms.Label lblNumTicket;
        private System.Windows.Forms.GroupBox grpHallLayout;
        private System.Windows.Forms.DataGridView dgvwHallTicket;
        private System.Windows.Forms.GroupBox grpSoldTickets;
        private System.Windows.Forms.DataGridView dgvwSoldTickets;
        private SoldTicketsDataSet soldTicketsDataSet;
        private System.Windows.Forms.BindingSource продажабилетовBindingSource;
        private SoldTicketsDataSetTableAdapters.Продажа_билетовTableAdapter продажа_билетовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефильмаDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn годвыпускаDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерместаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеррядаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзалаDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОклиентаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn времясеансаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеданныесотрудникаDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОсотрудникаDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn номербилетаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонклиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblYearFilmTicket;
        private System.Windows.Forms.ComboBox cboYearFilmTicket;
        private System.Windows.Forms.Label lblNumRowTicket;
        private System.Windows.Forms.Label lblNumPlaceTicket;
        private System.Windows.Forms.GroupBox grpTicketPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox picTicket;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Label lblNumTicketDelete;
        private System.Windows.Forms.Label lblNumberTicketDelete;
        private System.Windows.Forms.BindingSource Продажа_билетовBindingSource;
        private System.Windows.Forms.BindingSource Топ_кассировBindingSource;
        private System.Windows.Forms.TabControl tabReport;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзалаDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниезалаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоместDataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox grpWorkerHall;
        private System.Windows.Forms.TextBox txtNamePostWorkerHall;
        private System.Windows.Forms.Label lblNamePostWorkerHall;
        private System.Windows.Forms.MaskedTextBox txtmPassportWorkerHall;
        private System.Windows.Forms.Button btnUpdateWorkerHall;
        private System.Windows.Forms.Button btnDeleteWorkerHall;
        private System.Windows.Forms.Button btnAddWorkerHall;
        private System.Windows.Forms.DataGridView dgvwWorkerHall;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзалаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОсотрудникаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеданныесотрудникаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиедолжностиDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblPassportWorkerHall;
        private System.Windows.Forms.TextBox txtNameWorkerHall;
        private System.Windows.Forms.Label lblNameWorkerHall;
        private System.Windows.Forms.TextBox txtNumHallWorkerHall;
        private System.Windows.Forms.Label lblNumHallWorkerHall;
        private System.Windows.Forms.GroupBox grpWorker;
        private System.Windows.Forms.MaskedTextBox txtmPassport;
        private System.Windows.Forms.TextBox txtTitlePostWorker;
        private System.Windows.Forms.MaskedTextBox txtmPhoneWorker;
        private System.Windows.Forms.DataGridView dgvwWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОсотрудникаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеданныесотрудникаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиедолжностиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонасотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адрессотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdateWorker;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneWorker;
        private System.Windows.Forms.Label lblTitlePostWorker;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.TextBox txtNameWorker;
        private System.Windows.Forms.Label lblNameWorker;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.DataGridView dgvwPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиедолжностиDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниедолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDescriptionPost;
        private System.Windows.Forms.TextBox txtTitlePost;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnUpdatePost;
        private System.Windows.Forms.Label lblTitlePost;
        private System.Windows.Forms.Label lblDescriptionPost;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnDeletePost;
        private System.Windows.Forms.Button btnAddPost;
        private System.Windows.Forms.TabPage tabPage18;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage tabReportTicket;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Топ_клиентовBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource Кол_билетов_залаBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource Залы_без_фильмовBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource Топ_фильмовBindingSource;
        private System.Windows.Forms.NumericUpDown numYearFilm;
        private HallNumberDataSet hallNumberDataSet1;
        private HallNumberDataSet hallNumberDataSet2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown numYearSession;
        private System.Windows.Forms.NumericUpDown numYearSessionHall;
        private System.Windows.Forms.NumericUpDown numYearFilmShowFilm;
        private System.Windows.Forms.NumericUpDown numYearFilmAcquisitionLicense;
        private System.Windows.Forms.DateTimePicker dtmLicenseValidityPeriod;
        private System.Windows.Forms.NumericUpDown numYearFilmShowing;
    }
}

