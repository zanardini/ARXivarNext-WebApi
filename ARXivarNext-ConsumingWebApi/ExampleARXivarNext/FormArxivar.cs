using Abletech.WebApi.Client.Arxivar.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace ExampleARXivarNext
{
    public partial class FormArxivar : Form
    {
        string _authToken;
        string _refreshToken;

        public Abletech.WebApi.Client.Arxivar.Client.Configuration Configuration
        {
            get
            {
                return new Abletech.WebApi.Client.Arxivar.Client.Configuration()
                {
                    BasePath = _txtUrl.Text,
                    ApiKey = new Dictionary<string, string>() { { "Authorization", _authToken } },
                    ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } }
                };
            }
        }

        public FormArxivar()
        {
            InitializeComponent();

            if (System.IO.File.Exists(@"c:\temp\ARXivar\UsernameARXivar.txt"))
            {
                var txt = System.IO.File.ReadAllLines(@"c:\temp\ARXivar\UsernameARXivar.txt");
                if (txt.Length > 0)
                    _txtUrl.Text = txt[0];
                if (txt.Length > 1)
                    _txtUsername.Text = txt[1];
                if (txt.Length > 2)
                    _txtPassword.Text = txt[2];
                if (txt.Length > 3)
                    _txtClientId.Text = txt[3];
                if (txt.Length > 4)
                    _txtClientSecret.Text = txt[4];

            }
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                Abletech.WebApi.Client.Arxivar.Model.AuthenticationTokenRequestDTO arxLogonRequest = new Abletech.WebApi.Client.Arxivar.Model.AuthenticationTokenRequestDTO(_txtUsername.Text, _txtPassword.Text, _txtClientId.Text, _txtClientSecret.Text);
                var authApi = new Abletech.WebApi.Client.Arxivar.Api.AuthenticationApi(_txtUrl.Text);
                var resultToken = authApi.AuthenticationGetToken(arxLogonRequest);
                _authToken = resultToken.AccessToken;
                _refreshToken = resultToken.RefreshToken;
                _txtLog.Text = "AuthToken: " + _authToken;
                tabControl1.Enabled = true;

                _txtLog.Text += Environment.NewLine;

                var userApi = new Abletech.WebApi.Client.Arxivar.Api.UsersApi(Configuration);
                var userInfo = userApi.UsersGetUserInfo();
                _txtLog.Text += Environment.NewLine + "UserDescription: " + userInfo.CompleteDescription;
                _txtLog.Text += Environment.NewLine + "UserName: " + userInfo.CompleteName;
                _txtLog.Text += Environment.NewLine + "UserId: " + userInfo.User;
                _txtLog.Text += Environment.NewLine;

                Abletech.WebApi.Client.Arxivar.Api.LicenseApi licenseApi = new Abletech.WebApi.Client.Arxivar.Api.LicenseApi(Configuration);
                var licenseIsLoaded = licenseApi.LicenseLicenseIsLoaded();
                _txtLog.Text += Environment.NewLine + "License Is Loaded" + licenseIsLoaded;

                Abletech.WebApi.Client.Arxivar.Model.ServerLicense loadedLicense = licenseApi.LicenseGetLoadedlicense();
                _txtLog.Text += Environment.NewLine + "License Issuer: " + loadedLicense.Issuer;
                _txtLog.Text += Environment.NewLine + "License Type: " + loadedLicense.Purpose;
                _txtLog.Text += Environment.NewLine + "ActivationCode: " + loadedLicense.ActivationCode;
                _txtLog.Text += Environment.NewLine + "Note: " + loadedLicense.Note;
            }
            catch (Exception ex)
            {
                _txtLog.Text = ex.Message;
            }
        }

        private void BtnListAoo_Click(object sender, EventArgs e)
        {
            try
            {
                //Inizialize BusinessUnit Api
                var aooApi = new Abletech.WebApi.Client.Arxivar.Api.BusinessUnitsApi(Configuration);
                //Get Aoo list
                var businessUnits = aooApi.BusinessUnitsGet();
                //Bind to the grid as IEnumerable<T>
                Table.DataSource = businessUnits;

                ComboAoo.DataSource = businessUnits;
                ComboAoo.ValueMember = "Code";
                ComboAoo.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void BtnListDocumentType_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboAoo.SelectedItem == null)
                    throw new Exception("Selezionare l'AOO");

                var aooCode = ((Abletech.WebApi.Client.Arxivar.Model.BusinessUnitDTO)ComboAoo.SelectedItem).Code;
                //Inizialize DocumentTypes Api
                var docTypesApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi(Configuration);
                //Get DocumentTypes list

                var docTypes = docTypesApi.DocumentTypesGetOld(1, aooCode);
                //Bind to the grid
                Table.DataSource = docTypes;
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void BtnMaskList_Click(object sender, EventArgs e)
        {
            try
            {
                var maskApi = new Abletech.WebApi.Client.Arxivar.Api.MasksApi(Configuration);
                var masksList = maskApi.MasksGetList();
                Table.DataSource = masksList;

                ComboMask.DataSource = masksList;
                ComboMask.ValueMember = "Id";
                ComboMask.DisplayMember = "MaskName";
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void BtnMaskDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboMask.SelectedItem == null)
                    throw new Exception("Selezionare la maschera");

                var aooCode = ((Abletech.WebApi.Client.Arxivar.Model.MaskDTO)ComboMask.SelectedItem).Id;
                var maskApi = new Abletech.WebApi.Client.Arxivar.Api.MasksApi(Configuration);

                var selectedMask = (Abletech.WebApi.Client.Arxivar.Model.MaskDTO)ComboMask.SelectedItem;
                var maskDetails = maskApi.MasksGetById(selectedMask.Id);
                Table.DataSource = maskDetails.MaskDetails;
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void BtnPredefinedProfileList_Click(object sender, EventArgs e)
        {
            try
            {
                var predefinedProfilesApi = new Abletech.WebApi.Client.Arxivar.Api.PredefinedProfilesApi(Configuration);
                var predefProfiles = predefinedProfilesApi.PredefinedProfilesGet();
                Table.DataSource = predefProfiles;

                ComboPredefinedProfile.DataSource = predefProfiles;
                ComboPredefinedProfile.ValueMember = "Id";
                ComboPredefinedProfile.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void BtnPredefinedProfileDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboPredefinedProfile.SelectedItem == null)
                    throw new Exception("Selezionare il profilo predefinito");

                var predefinedProfileApi = new Abletech.WebApi.Client.Arxivar.Api.PredefinedProfilesApi(Configuration);
                var predefinedProfileSelected = (Abletech.WebApi.Client.Arxivar.Model.PredefinedProfileDTO)ComboPredefinedProfile.SelectedItem;
                var predefinedProfileDetail = predefinedProfileApi.PredefinedProfilesGetById(predefinedProfileSelected.Id);

                Table.DataSource = predefinedProfileDetail.Fields;

            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                var addressBookCategoryApi = new Abletech.WebApi.Client.Arxivar.Api.AddressBookCategoryApi(Configuration);
                var addressBookCategoryList = addressBookCategoryApi.AddressBookCategoryGet();
                Table.DataSource = addressBookCategoryList;
                ComboAddressBookCategory.DataSource = addressBookCategoryList;
                ComboAddressBookCategory.ValueMember = "Id";
                ComboAddressBookCategory.DisplayMember = "AddressBook";
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboAddressBookCategory.SelectedItem == null)
                    throw new Exception("Selezionare la categoria di rubrica");

                var addressBookSearchApi = new Abletech.WebApi.Client.Arxivar.Api.AddressBookSearchApi(Configuration);
                var search = addressBookSearchApi.AddressBookSearchGetSearch();
                var select = addressBookSearchApi.AddressBookSearchGetSelect();

                //Set search for specific addressbook category
                var catRubrica = search.IntFields.FirstOrDefault(i => i.Name.Equals("Dm_Rubrica.CATEGORIA", StringComparison.CurrentCultureIgnoreCase));
                catRubrica.Operator = 3;

                var selectedAddressBookCategory = ((Abletech.WebApi.Client.Arxivar.Model.AddressBookCategoryDTO)ComboAddressBookCategory.SelectedItem);
                catRubrica.Multiple = selectedAddressBookCategory.Id.ToString();

                //Set select for wanted fields
                select.Fields.ForEach(x => x.Selected = false);
                select.Fields.FirstOrDefault(i => i.Name == "DM_RUBRICA_SYSTEM_ID").Selected = true;
                select.Fields.FirstOrDefault(i => i.Name == "DM_RUBRICA_RAGIONE_SOCIALE").Selected = true;
                select.Fields.FirstOrDefault(i => i.Name == "DM_RUBRICA_CODICE").Selected = true;
                select.Fields.FirstOrDefault(i => i.Name == "DM_RUBRICA_AOO").Selected = true;
                select.Fields.FirstOrDefault(i => i.Name == "DM_RUBRICA_INDIRIZZO").Selected = true;
                select.Fields.FirstOrDefault(i => i.Name == "DM_RUBRICA_TEL").Selected = true;
                select.Fields.FirstOrDefault(i => i.Name == "DM_RUBRICA_LOCALITA").Selected = true;

                var addressBook = addressBookSearchApi.AddressBookSearchPostSearch(new Abletech.WebApi.Client.Arxivar.Model.AddressBookSearchConcreteCriteriaDTO(search, select));

                var adressBookResults = new DataTable();

                foreach (var columnSearchResult in addressBook.First().Columns)
                {
                    adressBookResults.Columns.Add(columnSearchResult.Id);

                    //if (!adressBookResults.Columns.Contains(columnSearchResult.Label))
                    //    adressBookResults.Columns.Add(columnSearchResult.Label);
                    //else
                    //    adressBookResults.Columns.Add(columnSearchResult.Label + Guid.NewGuid().ToString("n").Substring(0, 3));
                }

                foreach (var rowSearchResult in addressBook)
                    adressBookResults.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());

                Table.DataSource = adressBookResults;

                ComboAddressBookItems.DataSource = adressBookResults;
                ComboAddressBookItems.ValueMember = "DM_RUBRICA_SYSTEM_ID";
                ComboAddressBookItems.DisplayMember = "DM_RUBRICA_RAGIONE_SOCIALE";


            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                var addressBookApi = new Abletech.WebApi.Client.Arxivar.Api.AddressBookApi(Configuration);
                if (ComboAddressBookItems.SelectedItem == null)
                    throw new Exception("Selezionare l'item di rubrica");

                var systemId = int.Parse(ComboAddressBookItems.SelectedValue.ToString());
                var addressBookDto = addressBookApi.AddressBookGetById(systemId);

                addressBookDto.Location = "Updated at " + DateTime.Now.ToString("G");
                addressBookApi.AddressBookUpdateAddressBook(addressBookDto.Id, addressBookDto);

            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var searchApi = new Abletech.WebApi.Client.Arxivar.Api.SearchesApi(Configuration);

                var docTypesApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi(Configuration);
                var docTypes = docTypesApi.DocumentTypesGetOld(1, "AbleBS");
                var classeFatture = docTypes.FirstOrDefault(i => i.Key == "AMM.FATTACQ");

                var defaultSearch = searchApi.SearchesGet();
                var defaultSelect = searchApi.SearchesGetSelect_0(classeFatture.Id);

                var doctypefield = defaultSearch.Fields.FirstOrDefault(i => i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchDocumentTypeDto)doctypefield).Valore1 = new Abletech.WebApi.Client.Arxivar.Model.DocumentTypeSearchFilterDto(classeFatture.DocumentType, classeFatture.Type2, classeFatture.Type3);
                ((Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchDocumentTypeDto)doctypefield).Operator = 3;

                var additionals = searchApi.SearchesGetAdditionalByClasse(classeFatture.DocumentType, classeFatture.Type2, classeFatture.Type3, "AbleBS");
                var codiceFattura = additionals.FirstOrDefault(i => i.Description == "Numero della fattura");
                ((Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchStringDto)codiceFattura).Operator = 11; //non nullo e non vuoto;

                defaultSearch.Fields.Add(codiceFattura);
                defaultSelect.Fields.FirstOrDefault(i => i.Label == "Numero della fattura").Selected = true;

                var values = searchApi.SearchesPostSearch(new Abletech.WebApi.Client.Arxivar.Model.SearchCriteriaDto(defaultSearch, defaultSelect));
                var profiles = new DataTable();

                foreach (var columnSearchResult in values.First().Columns)
                {
                    profiles.Columns.Add(columnSearchResult.Id);
                }

                foreach (var rowSearchResult in values)
                {
                    profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                }
                Table.DataSource = profiles;
                ComboDocNumbers.DataSource = profiles;
                ComboDocNumbers.ValueMember = "DOCNUMBER";
                ComboDocNumbers.DisplayMember = "DOCNUMBER";
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboDocNumbers.SelectedItem == null)
                    throw new Exception("Selezionare il docnumber");

                var docNumber = System.Convert.ToInt32(ComboDocNumbers.Text);

                var documentApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentsApi(Configuration);

                var doc = documentApi.DocumentsGetForProfileWithHttpInfo(docNumber);
                var fileName = doc.Headers["Content-Disposition"].Replace("attachment; filename=", "");
                var buffer = new byte[doc.Data.Length];
                doc.Data.Read(buffer, 0, Convert.ToInt32(doc.Data.Length));

                var writeStream = System.IO.File.Create(fileName);
                doc.Data.Seek(0, System.IO.SeekOrigin.Begin);
                doc.Data.CopyTo(writeStream);
                writeStream.Close();

                System.Diagnostics.ProcessStartInfo pi = new System.Diagnostics.ProcessStartInfo(fileName);
                pi.UseShellExecute = true;
                pi.FileName = fileName;
                System.Diagnostics.Process.Start(pi);

            }
            catch (Exception ex)
            {
                _txtLog.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                var searchV2Api = new Abletech.WebApi.Client.Arxivar.Api.SearchesV2Api(Configuration);

                var docTypesApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi(Configuration);
                var docTypes = docTypesApi.DocumentTypesGetOld(1, "AbleBS");
                var classeFatture = docTypes.FirstOrDefault(i => i.Key == "AMM.FATTACQ");
                var classeBolle = docTypes.FirstOrDefault(i => i.Key == "AMM.BOL");

                //Get search for the first documentType
                var searchFatture = searchV2Api.SearchesV2GetEmpty();
                var doctypefieldFatture = searchFatture.Fields.FirstOrDefault(i => i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchDocumentTypeDto)doctypefieldFatture).Valore1 = new Abletech.WebApi.Client.Arxivar.Model.DocumentTypeSearchFilterDto(classeFatture.DocumentType, classeFatture.Type2, classeFatture.Type3);
                ((Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchDocumentTypeDto)doctypefieldFatture).Operator = 3;

                //Get search for the second documenttype
                var searchBolle = searchV2Api.SearchesV2GetEmpty();
                var doctypefieldBolle = searchBolle.Fields.FirstOrDefault(i =>
                    i.Name.Equals("DOCUMENTTYPE", StringComparison.CurrentCultureIgnoreCase));
                ((Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchDocumentTypeDto)doctypefieldBolle).Valore1 = new Abletech.WebApi.Client.Arxivar.Model.DocumentTypeSearchFilterDto(classeBolle.DocumentType, classeBolle.Type2, classeBolle.Type3);
                ((Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchDocumentTypeDto)doctypefieldBolle).Operator = 3;


                var baseSelect = searchV2Api.SearchesV2GetSelect_0(classeFatture.Id);

                var additionalsFatture = searchV2Api.SearchesV2GetAdditionalByClasse(classeFatture.DocumentType,
                    classeFatture.Type2, classeFatture.Type3, "AbleBS");
                var codiceFattura = additionalsFatture.FirstOrDefault(i => i.Description == "Codice Fattura");
                ((Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchStringDto)codiceFattura).Operator = 11; //non nullo e non vuoto;

                searchFatture.Fields.Add(codiceFattura);
                baseSelect.Fields.FirstOrDefault(i => i.Label == "Codice Fattura").Selected = true;
                baseSelect.Fields
                    .FirstOrDefault(i => i.Name.Equals("CLASSEDOCDESC", StringComparison.CurrentCultureIgnoreCase))
                    .Selected = true;
                baseSelect.MaxItems = 0;

                var values = searchV2Api.SearchesV2PostSearchMultiple(new Abletech.WebApi.Client.Arxivar.Model.SearchCriteriaMultipleDto()
                {
                    SearchFilterDtoList = new List<Abletech.WebApi.Client.Arxivar.Model.SearchDTO>() { searchFatture, searchBolle },
                    SelectFilterDto = baseSelect
                });

                var profiles = new DataTable();

                foreach (var columnSearchResult in values.First().Columns)
                {
                    profiles.Columns.Add(columnSearchResult.Id);
                }

                foreach (var rowSearchResult in values)
                {
                    profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                }
                Table.DataSource = profiles;
                ComboDocNumbers.DataSource = profiles;
                ComboDocNumbers.ValueMember = "DOCNUMBER";
                ComboDocNumbers.DisplayMember = "DOCNUMBER";
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                var bufferApi = new Abletech.WebApi.Client.Arxivar.Api.BufferApi(Configuration);
                var profileApi = new Abletech.WebApi.Client.Arxivar.Api.ProfilesApi(Configuration);
                var statesApi = new Abletech.WebApi.Client.Arxivar.Api.StatesApi(Configuration);

                var aooApi = new Abletech.WebApi.Client.Arxivar.Api.BusinessUnitsApi(Configuration);
                var aoo = aooApi.BusinessUnitsGet();

                var docTypesApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi(Configuration);
                var doctypes = docTypesApi.DocumentTypesGetOld(1, aoo.First().Code);

                var openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var stream = openFileDialog.OpenFile();
                    var bufferId = bufferApi.BufferInsert(stream);

                    var profileDto = profileApi.ProfilesGet_0();
                    var classeGneric = doctypes.FirstOrDefault(i => i.Key.Equals("GENERIC", StringComparison.CurrentCultureIgnoreCase));
                    var status = statesApi.StatesGet_0();
                    ((Abletech.WebApi.Client.Arxivar.Model.StateFieldDTO)profileDto.Fields.FirstOrDefault(i => i.Name.Equals("Stato", StringComparison.CurrentCultureIgnoreCase))).Value = status.First().Id;
                    ((Abletech.WebApi.Client.Arxivar.Model.DocumentTypeFieldDTO)profileDto.Fields.FirstOrDefault(i => i.Name.Equals("DocumentType"))).Value = classeGneric.Id;
                    ((Abletech.WebApi.Client.Arxivar.Model.OriginFieldDTO)profileDto.Fields.FirstOrDefault(i => i.Name.Equals("Origine", StringComparison.CurrentCultureIgnoreCase))).Value = 0;
                    profileDto.Document = new Abletech.WebApi.Client.Arxivar.Model.FileDTO(bufferId);

                    var additional = profileApi.ProfilesGetAdditionalByClasse(classeGneric.DocumentType, classeGneric.Type2, classeGneric.Type3, "AbleBS");
                    profileDto.Fields.AddRange(additional);

                    ((Abletech.WebApi.Client.Arxivar.Model.SubjectFieldDTO)profileDto.Fields.FirstOrDefault(i => i.Name.Equals("DOCNAME", StringComparison.CurrentCultureIgnoreCase))).Value = "Oggeto nuovo";
                    var result = profileApi.ProfilesPost(new Abletech.WebApi.Client.Arxivar.Model.ProfileDTO()
                    {
                        Fields = profileDto.Fields,
                        Document = new Abletech.WebApi.Client.Arxivar.Model.FileDTO() { BufferIds = bufferId },
                        Attachments = new List<string>(),
                        AuthorityData = new Abletech.WebApi.Client.Arxivar.Model.AuthorityDataDTO(),
                        Notes = new List<Abletech.WebApi.Client.Arxivar.Model.NoteDTO>(),
                        PaNotes = new List<string>(),
                        PostProfilationActions = new List<Abletech.WebApi.Client.Arxivar.Model.PostProfilationActionDTO>()
                    });

                    _txtLog.Text = "DocNumber generato: " + result.DocNumber.ToString();
                }
            }
            catch (Exception ex)
            {
                _txtLog.Text = ex.Message;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var profilesApi = new Abletech.WebApi.Client.Arxivar.Api.ProfilesApi(Configuration);
                var profile = profilesApi.ProfilesGetSchema(48, true);

                var oggetto = profile.Fields.FirstOrDefault(i => i.Name.Equals("DOCNAME", StringComparison.CurrentCultureIgnoreCase));
                ((Abletech.WebApi.Client.Arxivar.Model.SubjectFieldDTO)oggetto).Value = "Update from API call (DEV EXAMPLE)";

                var numerofattura = profile.Fields.FirstOrDefault(i => i.ExternalId != null && i.ExternalId.Equals("CodFatt", StringComparison.CurrentCultureIgnoreCase));
                ((Abletech.WebApi.Client.Arxivar.Model.AdditionalFieldStringDTO)numerofattura).Value = "CodFatt value (DEV EXAMPLE)";

                var profileToUpdate = new Abletech.WebApi.Client.Arxivar.Model.ProfileDTO();
                profileToUpdate.Fields = profile.Fields;
                profilesApi.ProfilesPut(48, profileToUpdate);

                _txtLog.Text = "Profile Updated";
            }
            catch (Exception ex)
            {
                _txtLog.Text = ex.Message;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            try
            {
                var wfApi = new Abletech.WebApi.Client.Arxivar.Api.WorkflowApi(Configuration);
                var documentApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentsApi(Configuration);


                if (ComboDocNumbers.SelectedItem == null)
                    throw new Exception("Selezionare il docnumber");

                var docNumber = System.Convert.ToInt32(ComboDocNumbers.Text);

                var manualStartEvents = wfApi.WorkflowGetEventsForManualStarts(new List<int?>() { docNumber });
                Table.DataSource = manualStartEvents;

                ComboWf.DataSource = manualStartEvents;
                ComboWf.ValueMember = "WorkFlowName";
                ComboWf.DisplayMember = "EventId";
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                var wfApi = new Abletech.WebApi.Client.Arxivar.Api.WorkflowApi(Configuration);
                var documentApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentsApi(Configuration);

                if (ComboDocNumbers.SelectedItem == null)
                    throw new Exception("Selezionare il docnumber");
                var docNumber = System.Convert.ToInt32(ComboDocNumbers.Text);

                if (ComboWf.SelectedItem == null)
                    throw new Exception("Selezionare l'evento di WorkFlow");
                var eventId = ((Abletech.WebApi.Client.Arxivar.Model.WorkFlowEventDTO)ComboWf.SelectedItem).EventId;

                wfApi.WorkflowWorkflowManualStart(docNumber, eventId);
                _txtLog.Text = "Avvio Workflow schedulato con successo";
            }
            catch (Exception ex)
            {
                _txtLog.Text = ex.Message;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                var taskApi = new Abletech.WebApi.Client.Arxivar.Api.TaskWorkApi(Configuration);
                var select = taskApi.TaskWorkGetDefaultSelect();
                var tasks = taskApi.TaskWorkGetTasks(new Abletech.WebApi.Client.Arxivar.Model.TaskWorkRequestDTO(select));

                var tasksTable = new DataTable();

                foreach (var columnSearchResult in tasks.First().Columns)
                {
                    tasksTable.Columns.Add(columnSearchResult.Id);
                }

                foreach (var rowSearchResult in tasks)
                {
                    tasksTable.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                }

                Table.DataSource = tasksTable;

                ComboTasks.DataSource = tasksTable;
                ComboTasks.ValueMember = "ID";
                ComboTasks.DisplayMember = "ID";
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var taskApi = new Abletech.WebApi.Client.Arxivar.Api.TaskWorkApi(Configuration);

                if (ComboTasks.SelectedItem == null)
                    throw new Exception("Selezionare il Task di workflow");

                var taskId = System.Convert.ToInt32(ComboTasks.Text);

                var exitcodes = taskApi.TaskWorkGetExitCodesByTaskWorkIds(new List<int?>() { taskId });
                Table.DataSource = exitcodes;
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var viewsBuilderApi = new Abletech.WebApi.Client.Arxivar.Api.ViewsBuilderApi(Configuration);

            Abletech.WebApi.Client.Arxivar.Model.ViewEditDTO dto = new Abletech.WebApi.Client.Arxivar.Model.ViewEditDTO();
            dto.Description = "TestSviluppo";
            dto.DocumentType = 0;
            dto.Type2 = 0;
            dto.Type3 = 0;
            dto.EditFields = new Abletech.WebApi.Client.Arxivar.Model.SearchDTO() { Fields = new List<Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchDTO>() };
            dto.SelectFields = viewsBuilderApi.ViewsBuilderGetSelect_0(0, 0, 0);

            var aooSelectField = dto.SelectFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.Name)) && x.Name.Equals("AOO", StringComparison.CurrentCultureIgnoreCase));
            if (aooSelectField != null)
                aooSelectField.Selected = true;

            var numeroSelectField = dto.SelectFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.Name)) && x.Name.Equals("NUMERO", StringComparison.CurrentCultureIgnoreCase));
            if (numeroSelectField != null)
                numeroSelectField.Selected = true;

            var classeDocDescSelectField = dto.SelectFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.Name)) && x.Name.Equals("CLASSEDOCDESC", StringComparison.CurrentCultureIgnoreCase));
            if (classeDocDescSelectField != null)
                classeDocDescSelectField.Selected = true;

            var classeDocSelectField = dto.SelectFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.Name)) && x.Name.Equals("CLASSEDOC", StringComparison.CurrentCultureIgnoreCase));
            if (classeDocSelectField != null)
                classeDocSelectField.Selected = true;

            //Abletech.WebApi.Client.Arxivar.Management.Api.


            //var aggiuntivoSelectField = dto.SelectFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.ExternalId)) && x.ExternalId.Equals("TECNICOSLTIPOLOGIA", StringComparison.CurrentCultureIgnoreCase));
            var aggiuntivoSelectField = dto.SelectFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.Name)) && x.Name.Equals("COMBO36_31", StringComparison.CurrentCultureIgnoreCase));
            if (aggiuntivoSelectField != null)
                aggiuntivoSelectField.Selected = true;

            dto.LockFields = viewsBuilderApi.ViewsBuilderGetSearch_0(0, 0, 0);

            //var aggiuntivoSearchField = dto.LockFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.ExternalId)) && x.ExternalId.Equals("TECNICOSLTIPOLOGIA", StringComparison.CurrentCultureIgnoreCase));
            var aggiuntivoSearchField = dto.LockFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.Name)) && x.Name.Equals("COMBO36_31", StringComparison.CurrentCultureIgnoreCase));

            if (aggiuntivoSearchField != null)
            {
                var aggiuntivoStringSearchField = aggiuntivoSearchField as Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchStringDto;
                if (aggiuntivoStringSearchField != null)
                {
                    aggiuntivoStringSearchField.Operator = 5;
                    aggiuntivoStringSearchField.Valore1 = "Sviluppo interno";
                }
            }

            //aggiuntivoSearchField = dto.LockFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.ExternalId)) && x.ExternalId.Equals("ORELAVOROPREVISTE", StringComparison.CurrentCultureIgnoreCase));
            aggiuntivoSearchField = dto.LockFields.Fields.FirstOrDefault(x => x != null && (!string.IsNullOrEmpty(x.Name)) && x.Name.Equals("NUMERIC29_31", StringComparison.CurrentCultureIgnoreCase));
            if (aggiuntivoSearchField != null)
            {
                var aggiuntivoStringIntField = aggiuntivoSearchField as Abletech.WebApi.Client.Arxivar.Model.FieldBaseForSearchIntDto;
                if (aggiuntivoStringIntField != null)
                {
                    aggiuntivoStringIntField.Operator = 5;
                    aggiuntivoStringIntField.Valore1 = 4;
                }
            }

            //FieldBaseForSearchIntDto
            //FieldBaseForSearchBoolDto
            //FieldBaseForSearchDoubleDto
            //FieldBaseForSearchConservazioneDto
            //FieldBaseForSearchListDto
            //FieldBaseForSearchContactDto
            //FieldBaseForSearchDocumentTypeDto
            //FieldBaseForSearchStringDto
            //FieldBaseForSearchDateTimeDto
            //FieldBaseForSearchStampDto
            //FieldBaseForSearchAooDto
            //FieldBaseForSearchProtocolloDto

            dto.AllowEmptyFilterMode = 0;
            dto.ShowFields = false;
            dto.ShowGroupsMode = 0;

            var result = viewsBuilderApi.ViewsBuilderEditView(dto);

            var viewsPermissionsApi = new Abletech.WebApi.Client.Arxivar.Api.ViewsPermissionsApi(Configuration);
            var dtoPermissions = viewsPermissionsApi.ViewsPermissionsGetPermissionByView(result.Id);

            dtoPermissions.UsersPermissions.Add(new Abletech.WebApi.Client.Arxivar.Model.UserPermissionDTO()
            {
                User = 5,
                Permissions = new List<Abletech.WebApi.Client.Arxivar.Model.PermissionItemDTO> { new Abletech.WebApi.Client.Arxivar.Model.PermissionItemDTO(0, true, false) }
            });

            viewsPermissionsApi.ViewsPermissionsWritePermissionByView(result.Id, dtoPermissions);

            var idVista = result.Id;
            var url = "https://localhost/ArxivarNextWebPortal/#!/view/" + idVista;
            //esempio https://localhost/ArxivarNextWebPortal/#!/view/56a417a52e4f4d6a845e7eff5b1216fd

            //cancello la vista
            var viewApi = new Abletech.WebApi.Client.Arxivar.Api.ViewsApi(Configuration);
            viewApi.ViewsDeleteView(idVista);
        }

        private void button14_Click(object sender, EventArgs e)
        {

            var bufferApi = new Abletech.WebApi.Client.Arxivar.Api.BufferApi(Configuration);
            var profileApi = new Abletech.WebApi.Client.Arxivar.Api.ProfilesApi(Configuration);

            var docTypesApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi(Configuration);
            var doctypes = docTypesApi.DocumentTypesGetOld(0, "ABLETECH");

            using (System.IO.FileStream stream = System.IO.File.Open(@"c:\temp\1.pdf", System.IO.FileMode.Open))
            {
                Abletech.WebApi.Client.Arxivar.Model.MaskProfileSchemaDTO profileDto = profileApi.ProfilesGet_0();

                var classeConsumi = doctypes.FirstOrDefault(i => i.Key.Equals("AMM.CONSCLIBP", StringComparison.CurrentCultureIgnoreCase));
                if (classeConsumi == null)
                    throw new Exception("Classe Consumi 'AMM.CONSCLIBP' non trovata in ARXivar.");

                Abletech.WebApi.Client.Arxivar.Model.DocumentTypeFieldDTO documentTypeField = profileDto.Fields.FirstOrDefault(i => i is Abletech.WebApi.Client.Arxivar.Model.DocumentTypeFieldDTO) as Abletech.WebApi.Client.Arxivar.Model.DocumentTypeFieldDTO;
                if (documentTypeField != null)
                    documentTypeField.Value = classeConsumi.Id;

                var additional = profileApi.ProfilesGetAdditionalByClasse(classeConsumi.DocumentType, classeConsumi.Type2, classeConsumi.Type3, "ABLETECH");
                profileDto.Fields.AddRange(additional);

                Abletech.WebApi.Client.Arxivar.Model.StateFieldDTO stateField = profileDto.Fields.FirstOrDefault(i => i is Abletech.WebApi.Client.Arxivar.Model.StateFieldDTO) as Abletech.WebApi.Client.Arxivar.Model.StateFieldDTO;
                if (stateField != null)
                    stateField.Value = "VALIDO";

                Abletech.WebApi.Client.Arxivar.Model.OriginFieldDTO originField = profileDto.Fields.FirstOrDefault(i => i is Abletech.WebApi.Client.Arxivar.Model.OriginFieldDTO) as Abletech.WebApi.Client.Arxivar.Model.OriginFieldDTO;
                if (originField != null)
                    originField.Value = 2;

                Abletech.WebApi.Client.Arxivar.Model.DocumentDateFieldDTO dataDocField = profileDto.Fields.FirstOrDefault(i => i is Abletech.WebApi.Client.Arxivar.Model.DocumentDateFieldDTO) as Abletech.WebApi.Client.Arxivar.Model.DocumentDateFieldDTO;
                //if (dataDocField != null)
                //    dataDocField.Value = dataElaborazione;

                var fieldCodiceBP = profileDto.Fields.FirstOrDefault(x => x != null && x.ExternalId == "codiceBP");
                //if (fieldCodiceBP != null)
                //    (fieldCodiceBP as Abletech.WebApi.Client.Arxivar.Model.AdditionalFieldIntDTO).Value = rivenditoreCodice;

                var fieldDescrizioneBP = profileDto.Fields.FirstOrDefault(x => x != null && x.ExternalId == "descrizioneBP");
                //if (fieldDescrizioneBP != null)
                //    (fieldDescrizioneBP as Abletech.WebApi.Client.Arxivar.Model.AdditionalFieldStringDTO).Value = rivenditoreDescrizione;

                var fieldTipoProdotto = profileDto.Fields.FirstOrDefault(x => x != null && x.ExternalId == "TipoProdotto");
                if (fieldTipoProdotto != null)
                    (fieldTipoProdotto as Abletech.WebApi.Client.Arxivar.Model.AdditionalFieldComboDTO).Value = "ARXivar NEXT";





                Abletech.WebApi.Client.Arxivar.Model.SubjectFieldDTO subjectField = profileDto.Fields.FirstOrDefault(i => i is Abletech.WebApi.Client.Arxivar.Model.SubjectFieldDTO) as Abletech.WebApi.Client.Arxivar.Model.SubjectFieldDTO;
                //if (subjectField != null)
                //    subjectField.Value = string.Format("Consumi ARXivar NEXT {0}", rivenditoreDescrizione);


                profileDto.Fields.RemoveAll(x => x != null && x.ExternalId == "EMAIL_NOTIFICA");

                var bufferId = bufferApi.BufferInsert(stream);
                profileDto.Document = new Abletech.WebApi.Client.Arxivar.Model.FileDTO(bufferId);

                var result = profileApi.ProfilesPost(new Abletech.WebApi.Client.Arxivar.Model.ProfileDTO()
                {
                    Fields = profileDto.Fields,
                    Document = new Abletech.WebApi.Client.Arxivar.Model.FileDTO() { BufferIds = bufferId },
                    Attachments = new List<string>(),
                    AuthorityData = new Abletech.WebApi.Client.Arxivar.Model.AuthorityDataDTO(),
                    Notes = new List<Abletech.WebApi.Client.Arxivar.Model.NoteDTO>(),
                    PaNotes = new List<string>(),
                    PostProfilationActions = new List<Abletech.WebApi.Client.Arxivar.Model.PostProfilationActionDTO>(),
                });

                var docnumber = result.DocNumber;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                var signApi = new Abletech.WebApi.Client.Arxivar.Api.SignApi(Configuration);
                if (ComboDocNumbers.SelectedItem == null)
                    throw new Exception("Selezionare il docnumber");

                var docNumber = System.Convert.ToInt32(ComboDocNumbers.Text);

                Abletech.WebApi.Client.Arxivar.Model.VerifyInfoDTO verifyInfoDTO = signApi.SignGetVerifyInfo(new Abletech.WebApi.Client.Arxivar.Model.VerifyInfoRequestDTO(docNumber, null, 14));
                _txtLog.Text = "FileName = " + verifyInfoDTO.FileName;
                foreach (var validationMessage in verifyInfoDTO.ValidationMessageList)
                    _txtLog.Text += Environment.NewLine + "ValidationMessage = " + validationMessage.LevelEnum + " - " + validationMessage.Description;
                foreach (var envelopeInfo in verifyInfoDTO.EnvelopeInfoList)
                {
                    _txtLog.Text += Environment.NewLine + "EnvelopeInfo = " + envelopeInfo.ToJson();
                }
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                var searchApi = new Abletech.WebApi.Client.Arxivar.Api.SearchesApi(Configuration);

                var docTypesApi = new Abletech.WebApi.Client.Arxivar.Api.DocumentTypesApi(Configuration);
                var docTypes = docTypesApi.DocumentTypesGetOld(1, "AbleBS");

                var defaultSearch = searchApi.SearchesGet();
                var defaultSelect = searchApi.SearchesGetSelect();

                var values = searchApi.SearchesPostSearch(new Abletech.WebApi.Client.Arxivar.Model.SearchCriteriaDto(defaultSearch, defaultSelect));
                var profiles = new DataTable();

                foreach (var columnSearchResult in values.First().Columns)
                {
                    profiles.Columns.Add(columnSearchResult.Id);
                }

                foreach (var rowSearchResult in values)
                {
                    profiles.Rows.Add(rowSearchResult.Columns.Select(i => i.Value).ToArray());
                }
                Table.DataSource = profiles;
                ComboDocNumbers.DataSource = profiles;
                ComboDocNumbers.ValueMember = "DOCNUMBER";
                ComboDocNumbers.DisplayMember = "DOCNUMBER";
            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                var signApi = new Abletech.WebApi.Client.Arxivar.Api.SignApi(Configuration);
                var signCertList = signApi.SignGetSignCertList();

                Table.DataSource = signCertList;
                ComboSignCert.DataSource = signCertList;
                ComboSignCert.ValueMember = "Id";
                ComboSignCert.DisplayMember = "CertDescription";

            }
            catch (Exception ex)
            {
                Table.DataSource = null;
                _txtLog.Text = ex.Message;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboDocNumbers.SelectedItem == null)
                    throw new Exception("Selezionare il docnumber");
                var docNumber = System.Convert.ToInt32(ComboDocNumbers.Text);
                if (ComboSignCert.SelectedItem == null)
                    throw new Exception("Selezionare il certificato di firma");

                var signApi = new Abletech.WebApi.Client.Arxivar.Api.SignApi(Configuration);

                Abletech.WebApi.Client.Arxivar.Model.SignCertDTO signCertDTO = ComboSignCert.SelectedItem as Abletech.WebApi.Client.Arxivar.Model.SignCertDTO;
                string password = "123456";
                string otp = "123456";
                List<Abletech.WebApi.Client.Arxivar.Model.RemoteSignElementRequestDTO> signElementList = new List<Abletech.WebApi.Client.Arxivar.Model.RemoteSignElementRequestDTO>();
                signElementList.Add(new Abletech.WebApi.Client.Arxivar.Model.RemoteSignElementRequestDTO(14, docNumber.ToString(), null, false, null));

                Abletech.WebApi.Client.Arxivar.Model.RemoteSignResponseDTO remoteSignResponseDTO = signApi.SignRemoteSign(new Abletech.WebApi.Client.Arxivar.Model.RemoteSignRequestDTO(signCertDTO.Id, password, null, otp, signElementList));
                string signRequestId = remoteSignResponseDTO.SignRequestId;

                Abletech.WebApi.Client.Arxivar.Api.QueueApi queueApi = new Abletech.WebApi.Client.Arxivar.Api.QueueApi(Configuration);
                Abletech.WebApi.Client.Arxivar.Model.QueueAggregationStatusInfoDto queueAggregationStatusInfoDto = queueApi.QueueGetQueueAggregationStatusInfo(signRequestId);
                var status = queueAggregationStatusInfoDto.QueueStatus;
            }
            catch (Exception ex)
            {
                _txtLog.Text = ex.Message;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                var authApi = new Abletech.WebApi.Client.Arxivar.Api.AuthenticationApi(Configuration);
                var ticket = authApi.AuthenticationInsertLogonTicket(new Abletech.WebApi.Client.Arxivar.Model.LogonTicketRequestDto(2, "", 1, null, _txtClientId.Text, _txtClientSecret.Text, null, null, null));

                _txtLog.Text = "Ottenuto un logon token per l'utente 2 valido one shot, Token: " + ticket.LogonTicket;

                var url = "http://localhost/ARXivarNextWebPortal/Account/LogonTicket/" + ticket.LogonTicket;
                _txtLogonToken.Text = url;
                //_txtLogonToken.Text = url + "?lang=EN&ReturnUrl=%2FARXivarNextWebPortal%2F#!/tasklistrepeater?showTask=1";
            }
            catch (Exception ex)
            {
                _txtLog.Text = ex.Message;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                var authApi = new Abletech.WebApi.Client.Arxivar.Api.AuthenticationApi(Configuration);
                var ticket = authApi.AuthenticationInsertLogonTicket(new Abletech.WebApi.Client.Arxivar.Model.LogonTicketRequestDto(2, "", null, DateTime.Now.AddDays(10), _txtClientId.Text, _txtClientSecret.Text, null, null, null));

                _txtLog.Text = "Ottenuto un logon token per l'utente 2 valido per 10 giorni, Token: " + ticket.LogonTicket;

                var url = "http://localhost/ARXivarNextWebPortal/Account/LogonTicket/" + ticket.LogonTicket;
                _txtLogonToken.Text = url;
                //_txtLogonToken.Text = url + "?lang=EN&ReturnUrl=%2FARXivarNextWebPortal%2F#!/tasklistrepeater?showTask=1";
            }
            catch (Exception ex)
            {
                _txtLog.Text = ex.Message;
            }
        }

        private void _btnLoginWindows_Click(object sender, EventArgs e)
        {
            try
            {
                var authApi = new Abletech.WebApi.Client.Arxivar.Api.AuthenticationApi(_txtUrl.Text);

                var logonProviderList = authApi.AuthenticationGetLogonProviderInfoList();
                var logonproviderWindows = logonProviderList.FirstOrDefault(x => x.LogonProviderId.Equals("0978F3606CD74CF292E9306BF58A6998"));

                AuthenticationTokenImplicitRequestDTO authenticationTokenImplicitRequestDto = new AuthenticationTokenImplicitRequestDTO(
                    _txtClientId.Text, //Client ID
                    _txtClientSecret.Text, // Client SECRET
                    logonproviderWindows.LogonProviderId, // Logon Provider ID
                    null, // Impersonate User ID
                    null, // impersonate External ID
                    "1.0.0.0", // CLIENT VERSION
                    "MyMachineKey", // MACHINE KEY
                    "IT", // CULTURE
                    "https://www.google.com", //Success redirect uri
                    new List<string>(), // SCOPE LIST
                    null //IP ADDRESS
                    );

                var resultToken = authApi.AuthenticationGetWindowsLogonRedirectUri(authenticationTokenImplicitRequestDto);

                if (resultToken.Error != null && !string.IsNullOrEmpty(resultToken.Error))
                    throw new Exception(string.Format("Error code [{0}] - {1}", resultToken.Error, resultToken.ErrorDescription));

                // Eseguo redirect per ottenere il token
                var requestLog = (HttpWebRequest)WebRequest.Create(resultToken.RedirectUri);
                requestLog.UseDefaultCredentials = true;
                using (var responseLog = (HttpWebResponse)requestLog.GetResponse())
                {
                    var responseFragment = responseLog.ResponseUri.Fragment;
                    if (string.IsNullOrEmpty(responseFragment))
                    {
                        // Provo a cercare la causa dell'errore
                        var queryParser = HttpUtility.ParseQueryString(responseLog.ResponseUri.Query);
                        var errorMessage = queryParser["errorMessage"] ?? "Redirect error: " + responseLog.ResponseUri;
                        throw new Exception(errorMessage);
                    }

                    var fragment = responseLog.ResponseUri.Fragment.Remove(0, 1);
                    var urlParameters = HttpUtility.ParseQueryString(fragment);

                    // extract the access token from the url.
                    _authToken = urlParameters["access_token"];
                }

                _refreshToken = "";
                _txtLog.Text = "AuthToken: " + _authToken;
                tabControl1.Enabled = true;

                _txtLog.Text += Environment.NewLine;

                var userApi = new Abletech.WebApi.Client.Arxivar.Api.UsersApi(Configuration);
                var userInfo = userApi.UsersGetUserInfo();
                _txtLog.Text += Environment.NewLine + "UserDescription: " + userInfo.CompleteDescription;
                _txtLog.Text += Environment.NewLine + "UserName: " + userInfo.CompleteName;
                _txtLog.Text += Environment.NewLine + "UserId: " + userInfo.User;
                _txtLog.Text += Environment.NewLine;

                Abletech.WebApi.Client.Arxivar.Api.LicenseApi licenseApi = new Abletech.WebApi.Client.Arxivar.Api.LicenseApi(Configuration);
                var licenseIsLoaded = licenseApi.LicenseLicenseIsLoaded();
                _txtLog.Text += Environment.NewLine + "License Is Loaded" + licenseIsLoaded;

                Abletech.WebApi.Client.Arxivar.Model.ServerLicense loadedLicense = licenseApi.LicenseGetLoadedlicense();
                _txtLog.Text += Environment.NewLine + "License Issuer: " + loadedLicense.Issuer;
                _txtLog.Text += Environment.NewLine + "License Type: " + loadedLicense.Purpose;
                _txtLog.Text += Environment.NewLine + "ActivationCode: " + loadedLicense.ActivationCode;
                _txtLog.Text += Environment.NewLine + "Note: " + loadedLicense.Note;




            }
            catch (Exception ex)
            {
                _txtLog.Text = ex.Message;
            }
        }
    }
}
