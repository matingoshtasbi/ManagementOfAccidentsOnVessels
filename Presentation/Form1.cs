using ManagementOfAccidentsOnVessels.Application.Missions.DTO;
using ManagementOfAccidentsOnVessels.Application.Missions.Service;
using ManagementOfAccidentsOnVessels.Application.PortsManagement.DTO;
using ManagementOfAccidentsOnVessels.Application.PortsManagement.Service;
using ManagementOfAccidentsOnVessels.Application.VesselsManagement;
using ManagementOfAccidentsOnVessels.Application.VesselsManagement.DTO;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace ManagementOfAccidentsOnVessels
{
    public partial class MainForm : Form
    {
        private readonly ICommandQueryVesselService _commandQueryVesselService;
        private readonly ICommandQueryMissionService _commandQueryMissionService;
        private readonly ICommandQueryPortService _commandQueryPortService;

        public MainForm(ICommandQueryVesselService commandQueryVesselService,
            ICommandQueryMissionService commandQueryMissionService,
            ICommandQueryPortService commandQueryPortService)
        {
            InitializeComponent();
            _commandQueryVesselService = commandQueryVesselService;
            _commandQueryMissionService = commandQueryMissionService;
            _commandQueryPortService = commandQueryPortService;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region vessel
            GetAllVessels();

            // Fetch Data To VesselTypeCombo
            var vesselTypes = _commandQueryVesselService.GetAllVesselTypes();
            vesselTypeCombo.DisplayMember = "Name";
            vesselTypeCombo.ValueMember = "Id";
            foreach (var item in vesselTypes)
            {
                vesselTypeCombo.Items.Add(item);
            }

            // Fetch Data To PortCombo
            var ports = _commandQueryPortService.GetAllPorts();
            portCombo.DisplayMember = "Name";
            portCombo.ValueMember = "Id";
            foreach (var item in ports)
            {
                portCombo.Items.Add(item);
            }

            #endregion

            #region accident
            // Fill Picture
            gulfPic.ImageLocation = Directory.GetCurrentDirectory() + "\\" + @"PersianGulfwithPorts.PNG";
            gulfPic.SizeMode = PictureBoxSizeMode.StretchImage;

            // Fetch Data To MissionTypeCombo
            var missionTypes = _commandQueryMissionService.GetAllMissionTypes();
            accidentCombo.DisplayMember = "Name";
            accidentCombo.ValueMember = "Id";
            foreach (var item in missionTypes)
            {
                accidentCombo.Items.Add(item);
            }
            #endregion

            #region init ui
            BackToDefaultForm();
            #endregion
        }

        private void GetAllVessels()
        {
            // Get Data
            var vessels = _commandQueryVesselService.GetAllVessels();

            // Bind Data To GridView
            DataTable dt = new DataTable();
            dt.Columns.Add("شناسه شناور");
            dt.Columns.Add("شماره سریال شناور");
            dt.Columns.Add("نام شناور");
            dt.Columns.Add("نوع شناور");
            dt.Columns.Add("حداکثر سرعت شناور");
            dt.Columns.Add("بندر");

            foreach (var item in vessels)
            {
                DataRow row = dt.NewRow();
                dt.Rows.Add(item.Id, item.SerialNumber, item.Name, item.VesselType, item.MaxSpeed, item.Port);
            }

            vesselManagementGv.DataSource = dt;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Validation();

                // find vesselTypeId and portId
                var vesselType = vesselTypeCombo.SelectedItem as VesselTypeDTO;
                var port = portCombo.SelectedItem as PortComboDTO;

                // create dto
                var dto = new AddVesselDTO()
                {
                    SerialNumber = serialNumberTxt.Text,
                    Name = nameTxt.Text,
                    VesselTypeId = vesselType!.Id,
                    MaxSpeed = int.Parse(maxSpeedTxt.Text),
                    PortId = port!.Id,
                    Detail = new VesselExtraDetailDTO()
                    {
                        BodyMaterial = bodyMaterialTxt.Text,
                        EngineModel = engineModelTxt.Text,
                        ManufacturerCountry = manufacturerCountryTxt.Text,
                        ManufacturerName = manufacturerNameTxt.Text,
                        Capacity = int.TryParse(capacityTxt.Text, out int res) ? res : null
                    }
                };

                _commandQueryVesselService.AddVessel(dto);

                GetAllVessels();
                ClearForm();
                BackToDefaultForm();

                MessageBox.Show("شناور با موفقیت ثبت شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Validation()
        {
            // parsing output varables
            decimal maxSpeed;

            // validation
            if (string.IsNullOrWhiteSpace(serialNumberTxt.Text))
                throw new Exception("شماره سریال شناور اجباریست");

            if (string.IsNullOrWhiteSpace(nameTxt.Text))
                throw new Exception("نام شناور اجباریست");

            if (string.IsNullOrWhiteSpace(vesselTypeCombo.Text))
                throw new Exception("نوع شناور اجباریست");

            if (!decimal.TryParse(maxSpeedTxt.Text, out maxSpeed))
                throw new Exception("حداکثر سرعت شناور باید عددی باشد");

            if (string.IsNullOrWhiteSpace(portCombo.Text))
                throw new Exception("بندر اجباریست");
        }

        private void vesselMenuBtn_Click(object sender, EventArgs e)
        {
            vesselManagementGb.Visible = true;
            accidentPanel.Visible = false;
        }

        private void accidentMenuBtn_Click(object sender, EventArgs e)
        {
            vesselManagementGb.Visible = false;
            accidentPanel.Visible = true;
        }

        private void gulfPic_Click(object sender, EventArgs e)
        {
            try
            {
                if (accidentCombo.SelectedItem == null)
                    throw new Exception("لطفا نوع ماموریت را وارد کنید");

                var mouseEvent = e as MouseEventArgs;

                var missionType = accidentCombo.SelectedItem as MissionTypeDTO;


                var mission = new MissionDTO()
                {
                    Lat = mouseEvent.X,
                    Lon = mouseEvent.Y,
                    MissionTypeId = missionType.Id
                };

                var result = _commandQueryMissionService.MissionSuggest(mission);

                MessageBox.Show("مناسب ترین شناور برای ماموریت مورد نظر \n شناور " + result.VesselName + " میباشد که  در بندر " + result.PortName + " قرار دارد" +
                    "\nبهترین زمان رسیدن به مقصد " + TimeSpan.FromHours((double)result.Duration).ToString("h\\:mm") + " ساعت میباشد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //MessageBox.Show("Lat : " + .ToString() + " , Lon : " + .ToString());
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            BackToDefaultForm();
        }

        private void BackToDefaultForm()
        {
            if (deleteBtn.Enabled || updateBtn.Enabled)
            {
                ClearForm();
            }

            saveBtn.Enabled = true;
            deleteBtn.Enabled = false;
            updateBtn.Enabled = false;
            vesselIdLbl.Visible = false;
            vesselIdTextLbl.Visible = false;
            isActiveChk.Visible = false;
            vesselManagementGv.ClearSelection();
        }

        private void ClearForm()
        {
            foreach (var item in vesselManagementGb.Controls)
            {
                if (item is TextBox)
                {
                    var txt = item as TextBox;
                    txt.Text = "";
                }
                else if (item is ComboBox)
                {
                    var combo = item as ComboBox;
                    combo.SelectedItem = null;
                }
                else if (item is CheckBox)
                {
                    var check = item as CheckBox;
                    check.Checked = false;
                }
            }
        }

        private void vesselManagementGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                foreach (var item in vesselManagementGb.Controls)
                {
                    if (item is TextBox)
                    {
                        var txt = item as TextBox;
                        txt.Text = "";
                    }
                    else if (item is ComboBox)
                    {
                        var combo = item as ComboBox;
                        combo.SelectedItem = null;
                    }
                }

                // ui
                saveBtn.Enabled = false;
                deleteBtn.Enabled = true;
                updateBtn.Enabled = true;
                vesselIdLbl.Visible = true;
                vesselIdTextLbl.Visible = true;
                isActiveChk.Visible = true;


                // Get Vessel Data
                var selectedItem = vesselManagementGv.SelectedRows[0];
                var id = long.Parse(selectedItem.Cells[0].Value.ToString()!);

                vesselIdLbl.Text = id.ToString();

                var result = _commandQueryVesselService.GetVessel(id);

                // Fill Textboxes and Combos
                // vessel
                serialNumberTxt.Text = result.SerialNumber;
                nameTxt.Text = result.Name;
                vesselTypeCombo.SelectedIndex = vesselTypeCombo.FindStringExact(result.VesselType);
                maxSpeedTxt.Text = result.MaxSpeed.ToString();
                portCombo.SelectedIndex = portCombo.FindStringExact(result.Port);
                isActiveChk.Checked = result.IsActive;

                // extra detail
                manufacturerCountryTxt.Text = result.Detail.ManufacturerCountry;
                manufacturerNameTxt.Text = result.Detail.ManufacturerName;
                capacityTxt.Text = result.Detail.Capacity.ToString();
                engineModelTxt.Text = result.Detail.EngineModel;
                bodyMaterialTxt.Text = result.Detail.BodyMaterial;
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // validate
                Validation();

                // find vesselTypeId and portId
                var vesselType = vesselTypeCombo.SelectedItem as VesselTypeDTO;
                var port = portCombo.SelectedItem as PortComboDTO;

                var updated = new UpdateVesselDTO()
                {
                    Id = long.Parse(vesselIdLbl.Text),
                    Name = nameTxt.Text,
                    SerialNumber = serialNumberTxt.Text,
                    MaxSpeed = decimal.Parse(maxSpeedTxt.Text),
                    VesselTypeId = vesselType.Id,
                    PortId = port.Id,
                    IsActive = isActiveChk.Checked,
                    Detail = new VesselExtraDetailDTO()
                    {
                        BodyMaterial = bodyMaterialTxt.Text,
                        Capacity = int.TryParse(capacityTxt.Text, out int res) ? res : null,
                        EngineModel = engineModelTxt.Text,
                        ManufacturerCountry = manufacturerCountryTxt.Text,
                        ManufacturerName = manufacturerNameTxt.Text
                    }
                };

                _commandQueryVesselService.UpdateVessel(updated);
                GetAllVessels();
                BackToDefaultForm();

                MessageBox.Show("شناور با موفقیت ویرایش شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _commandQueryVesselService.DeleteVessel(long.Parse(vesselIdLbl.Text));
                GetAllVessels();
                BackToDefaultForm();

                MessageBox.Show("شناور با موفقیت حذف شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}