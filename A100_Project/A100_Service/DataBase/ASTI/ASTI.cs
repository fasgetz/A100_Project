namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ASTI : DbContext
    {
        public ASTI()
            : base("name=ASTI")
        {
            Configuration.ProxyCreationEnabled = false;
            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<BasicCheckList> BasicCheckList { get; set; }
        public virtual DbSet<BasicDamage> BasicDamage { get; set; }
        public virtual DbSet<BoltedJoint> BoltedJoint { get; set; }
        public virtual DbSet<CheckList> CheckList { get; set; }
        public virtual DbSet<CheckListCriteria> CheckListCriteria { get; set; }
        public virtual DbSet<CheckListCriteriesTile> CheckListCriteriesTile { get; set; }
        public virtual DbSet<CheckListRecomendation> CheckListRecomendation { get; set; }
        public virtual DbSet<CheckListTile> CheckListTile { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ClientLicense> ClientLicense { get; set; }
        public virtual DbSet<ClientSchemePermissions> ClientSchemePermissions { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Conclusion> Conclusion { get; set; }
        public virtual DbSet<ConclusionPart> ConclusionPart { get; set; }
        public virtual DbSet<Connection> Connection { get; set; }
        public virtual DbSet<Control> Control { get; set; }
        public virtual DbSet<ControlEmployees> ControlEmployees { get; set; }
        public virtual DbSet<ControlMetod> ControlMetod { get; set; }
        public virtual DbSet<ControlProgram> ControlProgram { get; set; }
        public virtual DbSet<ControlProgramElement> ControlProgramElement { get; set; }
        public virtual DbSet<DefectType> DefectType { get; set; }
        public virtual DbSet<Deviation> Deviation { get; set; }
        public virtual DbSet<DeviationLocation> DeviationLocation { get; set; }
        public virtual DbSet<DeviationOrientation> DeviationOrientation { get; set; }
        public virtual DbSet<DeviationPlateLocation> DeviationPlateLocation { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Element> Element { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeConnection> EmployeeConnection { get; set; }
        public virtual DbSet<ExpertCommission> ExpertCommission { get; set; }
        public virtual DbSet<JornalCategory> JornalCategory { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }
        public virtual DbSet<Licenses> Licenses { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Map> Map { get; set; }
        public virtual DbSet<NuevoExpertComission> NuevoExpertComission { get; set; }
        public virtual DbSet<Orientation> Orientation { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<PartialTO> PartialTO { get; set; }
        public virtual DbSet<Photomaterial> Photomaterial { get; set; }
        public virtual DbSet<PhotoType> PhotoType { get; set; }
        public virtual DbSet<Recomendation> Recomendation { get; set; }
        public virtual DbSet<Resoult> Resoult { get; set; }
        public virtual DbSet<RiskLevel> RiskLevel { get; set; }
        public virtual DbSet<Safety> Safety { get; set; }
        public virtual DbSet<SafetyList> SafetyList { get; set; }
        public virtual DbSet<SafetyListCategory> SafetyListCategory { get; set; }
        public virtual DbSet<SafetyListCriteria> SafetyListCriteria { get; set; }
        public virtual DbSet<ShortUser> ShortUser { get; set; }
        public virtual DbSet<Specifications> Specifications { get; set; }
        public virtual DbSet<SpecificationsElement> SpecificationsElement { get; set; }
        public virtual DbSet<StillageTest> StillageTest { get; set; }
        public virtual DbSet<StillageType> StillageType { get; set; }
        public virtual DbSet<StockElements> StockElements { get; set; }
        public virtual DbSet<Support> Support { get; set; }
        public virtual DbSet<Vik> Vik { get; set; }
        public virtual DbSet<VikElement> VikElement { get; set; }
        public virtual DbSet<Warhouse> Warhouse { get; set; }
        public virtual DbSet<ClientPermissions> ClientPermissions { get; set; }
        public virtual DbSet<ElementsOfType> ElementsOfType { get; set; }
        public virtual DbSet<v_ClientLicenses> v_ClientLicenses { get; set; }
        public virtual DbSet<v_Clients> v_Clients { get; set; }
        public virtual DbSet<v_CompanyLicenses> v_CompanyLicenses { get; set; }
        public virtual DbSet<v_FindedDamages> v_FindedDamages { get; set; }
        public virtual DbSet<v_GetBasicDamage> v_GetBasicDamage { get; set; }
        public virtual DbSet<v_GetControl> v_GetControl { get; set; }
        public virtual DbSet<v_GetDamage> v_GetDamage { get; set; }
        public virtual DbSet<v_GetDeviationByUnit> v_GetDeviationByUnit { get; set; }
        public virtual DbSet<v_GetElementsLoad> v_GetElementsLoad { get; set; }
        public virtual DbSet<v_GetMap> v_GetMap { get; set; }
        public virtual DbSet<v_GetPartialTOChart> v_GetPartialTOChart { get; set; }
        public virtual DbSet<v_GetProjects> v_GetProjects { get; set; }
        public virtual DbSet<v_GetRadarSafetyChart> v_GetRadarSafetyChart { get; set; }
        public virtual DbSet<v_GetSafety> v_GetSafety { get; set; }
        public virtual DbSet<v_GetSafetyChart> v_GetSafetyChart { get; set; }
        public virtual DbSet<v_GetSpecificationsElement> v_GetSpecificationsElement { get; set; }
        public virtual DbSet<v_GetSpecificationsElement_old> v_GetSpecificationsElement_old { get; set; }
        public virtual DbSet<v_GetVik> v_GetVik { get; set; }
        public virtual DbSet<v_GetVikByUnit> v_GetVikByUnit { get; set; }
        public virtual DbSet<v_GetWarhouses> v_GetWarhouses { get; set; }
        public virtual DbSet<v_GetWork> v_GetWork { get; set; }
        public virtual DbSet<v_LogEvents> v_LogEvents { get; set; }
        public virtual DbSet<v_Projects> v_Projects { get; set; }
        public virtual DbSet<v_ReportBasicCheckList> v_ReportBasicCheckList { get; set; }
        public virtual DbSet<v_ReportBoltedJoint> v_ReportBoltedJoint { get; set; }
        public virtual DbSet<v_ReportCheckList> v_ReportCheckList { get; set; }
        public virtual DbSet<v_ReportClientDocuments> v_ReportClientDocuments { get; set; }
        public virtual DbSet<v_ReportConsolidatedStoika> v_ReportConsolidatedStoika { get; set; }
        public virtual DbSet<v_ReportControlProgram> v_ReportControlProgram { get; set; }
        public virtual DbSet<v_ReportDamage> v_ReportDamage { get; set; }
        public virtual DbSet<v_ReportDeviation> v_ReportDeviation { get; set; }
        public virtual DbSet<v_ReportPhotomaterial> v_ReportPhotomaterial { get; set; }
        public virtual DbSet<v_ReportRecomendation> v_ReportRecomendation { get; set; }
        public virtual DbSet<v_ReportReferenceCheckList> v_ReportReferenceCheckList { get; set; }
        public virtual DbSet<v_ReportReferenceCheckListAct> v_ReportReferenceCheckListAct { get; set; }
        public virtual DbSet<v_ReportRS> v_ReportRS { get; set; }
        public virtual DbSet<v_ReportSeBalka> v_ReportSeBalka { get; set; }
        public virtual DbSet<v_ReportSEost> v_ReportSEost { get; set; }
        public virtual DbSet<v_ReportSERama> v_ReportSERama { get; set; }
        public virtual DbSet<v_ReportSeStoika> v_ReportSeStoika { get; set; }
        public virtual DbSet<v_ReportSpecifications> v_ReportSpecifications { get; set; }
        public virtual DbSet<v_ReportSpecificationsElement> v_ReportSpecificationsElement { get; set; }
        public virtual DbSet<v_ReportStillageLoadTest> v_ReportStillageLoadTest { get; set; }
        public virtual DbSet<v_ReportVik> v_ReportVik { get; set; }
        public virtual DbSet<v_ReportVikByName> v_ReportVikByName { get; set; }
        public virtual DbSet<v_RobustoVIK> v_RobustoVIK { get; set; }
        public virtual DbSet<v_Specifications> v_Specifications { get; set; }
        public virtual DbSet<v_SpecificationsElementSize> v_SpecificationsElementSize { get; set; }
        public virtual DbSet<v_StockElements> v_StockElements { get; set; }
        public virtual DbSet<v_test_ellcount> v_test_ellcount { get; set; }
        public virtual DbSet<v_test_red> v_test_red { get; set; }
        public virtual DbSet<v_testProp> v_testProp { get; set; }
        public virtual DbSet<v_Vik> v_Vik { get; set; }
        public virtual DbSet<v_WarehouseKey> v_WarehouseKey { get; set; }
        public virtual DbSet<v_Warehouses> v_Warehouses { get; set; }
        public virtual DbSet<v_WarhouseLicenses> v_WarhouseLicenses { get; set; }
        public virtual DbSet<View_1> View_1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasicDamage>()
                .Property(e => e.BasicDamageName)
                .IsUnicode(false);

            modelBuilder.Entity<BasicDamage>()
                .HasMany(e => e.BasicCheckList)
                .WithRequired(e => e.BasicDamage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BoltedJoint>()
                .Property(e => e.FrameAverageValue)
                .HasPrecision(12, 1);

            modelBuilder.Entity<BoltedJoint>()
                .Property(e => e.AnchorAverageValue)
                .HasPrecision(12, 1);

            modelBuilder.Entity<BoltedJoint>()
                .Property(e => e.FrameValues)
                .IsUnicode(false);

            modelBuilder.Entity<BoltedJoint>()
                .Property(e => e.AnchorValues)
                .IsUnicode(false);

            modelBuilder.Entity<CheckListCriteria>()
                .HasMany(e => e.CheckList)
                .WithRequired(e => e.CheckListCriteria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CheckListTile>()
                .HasMany(e => e.CheckListCriteriesTile)
                .WithRequired(e => e.CheckListTile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Conclusion>()
                .Property(e => e.ExpertConclusion)
                .IsUnicode(false);

            modelBuilder.Entity<Conclusion>()
                .Property(e => e.TechnicalWriterConclusion)
                .IsUnicode(false);

            modelBuilder.Entity<Connection>()
                .Property(e => e.UserKey)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.ProjectNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.EmployeesList)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .HasMany(e => e.Resoult)
                .WithRequired(e => e.Control)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Control>()
                .HasMany(e => e.ControlEmployees)
                .WithRequired(e => e.Control)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Control>()
                .HasMany(e => e.ControlProgram)
                .WithRequired(e => e.Control)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ControlMetod>()
                .Property(e => e.InspectionMetod)
                .IsUnicode(false);

            modelBuilder.Entity<ControlProgramElement>()
                .HasMany(e => e.ControlProgram)
                .WithRequired(e => e.ControlProgramElement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DefectType>()
                .Property(e => e.DefectName)
                .IsUnicode(false);

            modelBuilder.Entity<Deviation>()
                .Property(e => e.mX)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Deviation>()
                .Property(e => e.mY)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Deviation>()
                .Property(e => e.mRotation)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Deviation>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<Deviation>()
                .Property(e => e.FrameRange)
                .IsUnicode(false);

            modelBuilder.Entity<DeviationLocation>()
                .Property(e => e.DeviationLocationName)
                .IsUnicode(false);

            modelBuilder.Entity<DeviationOrientation>()
                .Property(e => e.DeviationOrientationName)
                .IsUnicode(false);

            modelBuilder.Entity<DeviationPlateLocation>()
                .Property(e => e.DeviationPlateLocationName)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.DocumentName)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.DocumentPath)
                .IsUnicode(false);

            modelBuilder.Entity<Element>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<Element>()
                .Property(e => e.Format)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Support)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Employee1)
                .WithRequired(e => e.Employee2);

            modelBuilder.Entity<EmployeeConnection>()
                .Property(e => e.UserKey)
                .IsUnicode(false);

            modelBuilder.Entity<ExpertCommission>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<ExpertCommission>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<ExpertCommission>()
                .Property(e => e.QualificationLevel)
                .IsUnicode(false);

            modelBuilder.Entity<ExpertCommission>()
                .Property(e => e.IdentificationFrontSide)
                .IsUnicode(false);

            modelBuilder.Entity<ExpertCommission>()
                .Property(e => e.IdentificationBackSide)
                .IsUnicode(false);

            modelBuilder.Entity<ExpertCommission>()
                .Property(e => e.CertificationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<JornalCategory>()
                .Property(e => e.JornalCategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<JornalCategory>()
                .HasMany(e => e.Journal)
                .WithRequired(e => e.JornalCategory)
                .HasForeignKey(e => e.JournalCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Journal>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<Journal>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Licenses>()
                .HasMany(e => e.ClientLicense)
                .WithRequired(e => e.Licenses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Map>()
                .Property(e => e.X)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Map>()
                .Property(e => e.Y)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Map>()
                .Property(e => e.Width)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Map>()
                .Property(e => e.Height)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Map>()
                .Property(e => e.MapUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Map>()
                .Property(e => e.сLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Map>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<Map>()
                .HasMany(e => e.StillageTest)
                .WithRequired(e => e.Map)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orientation>()
                .Property(e => e.Orientation1)
                .IsUnicode(false);

            modelBuilder.Entity<Photomaterial>()
                .Property(e => e.PhotoСaption)
                .IsUnicode(false);

            modelBuilder.Entity<PhotoType>()
                .Property(e => e.PhotoTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<PhotoType>()
                .HasMany(e => e.Photomaterial)
                .WithRequired(e => e.PhotoType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recomendation>()
                .HasMany(e => e.CheckListRecomendation)
                .WithRequired(e => e.Recomendation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resoult>()
                .HasMany(e => e.BoltedJoint)
                .WithRequired(e => e.Resoult)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resoult>()
                .HasMany(e => e.ClientSchemePermissions)
                .WithRequired(e => e.Resoult)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resoult>()
                .HasMany(e => e.PartialTO)
                .WithRequired(e => e.Resoult)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resoult>()
                .HasMany(e => e.StillageTest)
                .WithRequired(e => e.Resoult)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RiskLevel>()
                .Property(e => e.RiscLevelName)
                .IsUnicode(false);

            modelBuilder.Entity<Safety>()
                .HasOptional(e => e.Safety1)
                .WithRequired(e => e.Safety2);

            modelBuilder.Entity<SafetyListCategory>()
                .HasMany(e => e.SafetyListCriteria)
                .WithRequired(e => e.SafetyListCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SafetyListCriteria>()
                .HasMany(e => e.SafetyList)
                .WithRequired(e => e.SafetyListCriteria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShortUser>()
                .Property(e => e.UserKey)
                .IsUnicode(false);

            modelBuilder.Entity<Specifications>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<Specifications>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<Specifications>()
                .HasMany(e => e.BasicCheckList)
                .WithRequired(e => e.Specifications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specifications>()
                .HasMany(e => e.BoltedJoint)
                .WithRequired(e => e.Specifications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specifications>()
                .HasMany(e => e.Map)
                .WithRequired(e => e.Specifications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specifications>()
                .HasMany(e => e.StillageTest)
                .WithRequired(e => e.Specifications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specifications>()
                .HasMany(e => e.StockElements)
                .WithRequired(e => e.Specifications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.eH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.eB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.eL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.erb)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.eA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.eC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.era)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.barName)
                .IsUnicode(false);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.fE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SpecificationsElement>()
                .Property(e => e.fD)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SpecificationsElement>()
                .HasMany(e => e.StillageTest)
                .WithRequired(e => e.SpecificationsElement)
                .HasForeignKey(e => e.LoadElementID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecificationsElement>()
                .HasMany(e => e.StillageTest1)
                .WithRequired(e => e.SpecificationsElement1)
                .HasForeignKey(e => e.StoikaElementID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecificationsElement>()
                .HasMany(e => e.StillageTest2)
                .WithRequired(e => e.SpecificationsElement2)
                .HasForeignKey(e => e.FrameElementID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StillageType>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<StockElements>()
                .HasOptional(e => e.StockElements1)
                .WithRequired(e => e.StockElements2);

            modelBuilder.Entity<Support>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<Support>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<Vik>()
                .Property(e => e.cComment)
                .IsUnicode(false);

            modelBuilder.Entity<Vik>()
                .Property(e => e.mX)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Vik>()
                .Property(e => e.mY)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Vik>()
                .Property(e => e.mRotation)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Vik>()
                .Property(e => e.ElementOrientation)
                .IsUnicode(false);

            modelBuilder.Entity<Vik>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<Vik>()
                .Property(e => e.nLevel)
                .IsUnicode(false);

            modelBuilder.Entity<Vik>()
                .Property(e => e.FrameRange)
                .IsUnicode(false);

            modelBuilder.Entity<VikElement>()
                .Property(e => e.StructuralMemberName)
                .IsUnicode(false);

            modelBuilder.Entity<Warhouse>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<Warhouse>()
                .HasMany(e => e.JornalCategory)
                .WithOptional(e => e.Warhouse)
                .HasForeignKey(e => e.WarehouseID);

            modelBuilder.Entity<Warhouse>()
                .HasMany(e => e.Journal)
                .WithRequired(e => e.Warhouse)
                .HasForeignKey(e => e.WarehouseID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warhouse>()
                .HasMany(e => e.PartialTO)
                .WithRequired(e => e.Warhouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warhouse>()
                .HasMany(e => e.Safety)
                .WithRequired(e => e.Warhouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warhouse>()
                .HasMany(e => e.SafetyListCategory)
                .WithRequired(e => e.Warhouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warhouse>()
                .HasMany(e => e.StockElements)
                .WithRequired(e => e.Warhouse)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<v_ClientLicenses>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ClientLicenses>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Clients>()
                .Property(e => e.UserKey)
                .IsUnicode(false);

            modelBuilder.Entity<v_CompanyLicenses>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetBasicDamage>()
                .Property(e => e.BasicDamageName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetControl>()
                .Property(e => e.InspectionMetod)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetControl>()
                .Property(e => e.ProjectNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetControl>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetControl>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetDamage>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetDamage>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetDamage>()
                .Property(e => e.element)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetDamage>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetDamage>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetDamage>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetDeviationByUnit>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetDeviationByUnit>()
                .Property(e => e.mX)
                .HasPrecision(12, 2);

            modelBuilder.Entity<v_GetDeviationByUnit>()
                .Property(e => e.mY)
                .HasPrecision(12, 2);

            modelBuilder.Entity<v_GetDeviationByUnit>()
                .Property(e => e.mRotation)
                .HasPrecision(12, 2);

            modelBuilder.Entity<v_GetElementsLoad>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetElementsLoad>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetElementsLoad>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetElementsLoad>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetMap>()
                .Property(e => e.X)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetMap>()
                .Property(e => e.Y)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetMap>()
                .Property(e => e.Width)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetMap>()
                .Property(e => e.Height)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetMap>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetMap>()
                .Property(e => e.MapUnit)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetMap>()
                .Property(e => e.сLevel)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetProjects>()
                .Property(e => e.UserKey)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetProjects>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetProjects>()
                .Property(e => e.ProjectNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.eH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.eB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.eL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.erb)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.eA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.eC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.era)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.barName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.fE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetSpecificationsElement>()
                .Property(e => e.fD)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_GetSpecificationsElement_old>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVik>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVik>()
                .Property(e => e.nLevel)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVik>()
                .Property(e => e.cComment)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVik>()
                .Property(e => e.mX)
                .HasPrecision(12, 2);

            modelBuilder.Entity<v_GetVik>()
                .Property(e => e.mY)
                .HasPrecision(12, 2);

            modelBuilder.Entity<v_GetVik>()
                .Property(e => e.mRotation)
                .HasPrecision(12, 2);

            modelBuilder.Entity<v_GetVik>()
                .Property(e => e.ElementOrientation)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVik>()
                .Property(e => e.FrameRange)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVikByUnit>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVikByUnit>()
                .Property(e => e.nLevel)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVikByUnit>()
                .Property(e => e.cComment)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVikByUnit>()
                .Property(e => e.mX)
                .HasPrecision(12, 2);

            modelBuilder.Entity<v_GetVikByUnit>()
                .Property(e => e.mY)
                .HasPrecision(12, 2);

            modelBuilder.Entity<v_GetVikByUnit>()
                .Property(e => e.mRotation)
                .HasPrecision(12, 2);

            modelBuilder.Entity<v_GetVikByUnit>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetVikByUnit>()
                .Property(e => e.FrameRange)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetWarhouses>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetWarhouses>()
                .Property(e => e.UserKey)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetWork>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetWork>()
                .Property(e => e.InspectionMetod)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetWork>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetWork>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetWork>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_GetWork>()
                .Property(e => e.ProjectNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_LogEvents>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_LogEvents>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Projects>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Projects>()
                .Property(e => e.ProjectNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportBasicCheckList>()
                .Property(e => e.BasicDamageName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportBoltedJoint>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportBoltedJoint>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportBoltedJoint>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportBoltedJoint>()
                .Property(e => e.FrameAverageValue)
                .HasPrecision(12, 1);

            modelBuilder.Entity<v_ReportBoltedJoint>()
                .Property(e => e.AnchorAverageValue)
                .HasPrecision(12, 1);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.eH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.eB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.eL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.erb)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.eA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.eC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.era)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportConsolidatedStoika>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDamage>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDamage>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDamage>()
                .Property(e => e.element)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDamage>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDamage>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDamage>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.DeviationLocationName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.DeviationPlateLocationName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.FrameRange)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportDeviation>()
                .Property(e => e.DeviationDirection)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportPhotomaterial>()
                .Property(e => e.PhotoTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportPhotomaterial>()
                .Property(e => e.FinalCaption)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportReferenceCheckList>()
                .Property(e => e.BasicDamageName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportReferenceCheckListAct>()
                .Property(e => e.BasicDamageName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportRS>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportRS>()
                .Property(e => e.eH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportRS>()
                .Property(e => e.eB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportRS>()
                .Property(e => e.eL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportRS>()
                .Property(e => e.erb)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportRS>()
                .Property(e => e.eC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeBalka>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSeBalka>()
                .Property(e => e.eH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeBalka>()
                .Property(e => e.eB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeBalka>()
                .Property(e => e.eL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeBalka>()
                .Property(e => e.eC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeBalka>()
                .Property(e => e.erb)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSEost>()
                .Property(e => e.El)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSEost>()
                .Property(e => e.eH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSEost>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSEost>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSERama>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSERama>()
                .Property(e => e.eH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSERama>()
                .Property(e => e.eB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSERama>()
                .Property(e => e.eA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSERama>()
                .Property(e => e.eC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSERama>()
                .Property(e => e.fE)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSERama>()
                .Property(e => e.fD)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeStoika>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSeStoika>()
                .Property(e => e.eH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeStoika>()
                .Property(e => e.eB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeStoika>()
                .Property(e => e.eL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeStoika>()
                .Property(e => e.erb)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeStoika>()
                .Property(e => e.eA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeStoika>()
                .Property(e => e.eC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSeStoika>()
                .Property(e => e.era)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportSpecifications>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSpecifications>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSpecifications>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSpecificationsElement>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSpecificationsElement>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSpecificationsElement>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSpecificationsElement>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportSpecificationsElement>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.BalkaEH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.BalkaEB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.BalkaEL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.StoikaEB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.StoikaEH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.FrameEB)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.FrameEH)
                .HasPrecision(10, 2);

            modelBuilder.Entity<v_ReportStillageLoadTest>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.nLevel)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.StructuralMemberName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.DefectName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.RiscLevelName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.cComment)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVik>()
                .Property(e => e.FrameRange)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.nLevel)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.StructuralMemberName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.DefectName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.RiscLevelName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.cComment)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.FrameRange)
                .IsUnicode(false);

            modelBuilder.Entity<v_ReportVikByName>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<v_RobustoVIK>()
                .Property(e => e.cComment)
                .IsUnicode(false);

            modelBuilder.Entity<v_RobustoVIK>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<v_RobustoVIK>()
                .Property(e => e.FrameRange)
                .IsUnicode(false);

            modelBuilder.Entity<v_RobustoVIK>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_RobustoVIK>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_RobustoVIK>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_RobustoVIK>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Specifications>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Specifications>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_Specifications>()
                .Property(e => e.StillageTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<v_SpecificationsElementSize>()
                .Property(e => e.ManufacturedStillage)
                .IsUnicode(false);

            modelBuilder.Entity<v_SpecificationsElementSize>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_SpecificationsElementSize>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_StockElements>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_StockElements>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_test_ellcount>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_test_red>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_test_red>()
                .Property(e => e.ProjectNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_testProp>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_testProp>()
                .Property(e => e.ProjectNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_Vik>()
                .Property(e => e.cComment)
                .IsUnicode(false);

            modelBuilder.Entity<v_Vik>()
                .Property(e => e.nLevel)
                .IsUnicode(false);

            modelBuilder.Entity<v_Vik>()
                .Property(e => e.Row)
                .IsUnicode(false);

            modelBuilder.Entity<v_Vik>()
                .Property(e => e.ElementSize)
                .IsUnicode(false);

            modelBuilder.Entity<v_Vik>()
                .Property(e => e.ElementName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Vik>()
                .Property(e => e.ElementOrientation)
                .IsUnicode(false);

            modelBuilder.Entity<v_Vik>()
                .Property(e => e.FrameRange)
                .IsUnicode(false);

            modelBuilder.Entity<v_Vik>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Warehouses>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Warehouses>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Warehouses>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<v_WarhouseLicenses>()
                .Property(e => e.WarhouseName)
                .IsUnicode(false);
        }
    }
}
