using System;
using A100_AspNetCore.Models.A100_Models.DataBase._Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class ASTIContext : DbContext
    {
        public ASTIContext()
        {
        }

        public ASTIContext(DbContextOptions<ASTIContext> options)
            : base(options)
        {
        }

        // Представления
        public virtual DbQuery<v_GetWork> v_GetWork { get; set; }
        public virtual DbQuery<v_GetProjects> v_GetProjects { get; set; }



        // Таблицы
        public virtual DbSet<ElementsOfType> ElementsOfTypes { get; set; }
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
        public virtual DbSet<PartialTo> PartialTo { get; set; }
        public virtual DbSet<PhotoType> PhotoType { get; set; }
        public virtual DbSet<Photomaterial> Photomaterial { get; set; }
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

        // Unable to generate entity type for table 'dbo.ElementsOfType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ClientPermissions'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ASTI\\ASTISQL;Database=ASTI;Trusted_Connection=False;MultipleActiveResultSets=false; User ID=sa;Password=gbhjcKJK4509");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<BasicCheckList>(entity =>
            {
                entity.Property(e => e.BasicCheckListId).HasColumnName("BasicCheckListID");

                entity.Property(e => e.BasicDamageId).HasColumnName("BasicDamageID");

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.SpecificationsId).HasColumnName("SpecificationsID");

                entity.HasOne(d => d.BasicDamage)
                    .WithMany(p => p.BasicCheckList)
                    .HasForeignKey(d => d.BasicDamageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BasicCheckList_BasicDamage");

                entity.HasOne(d => d.Resoult)
                    .WithMany(p => p.BasicCheckList)
                    .HasForeignKey(d => d.ResoultId)
                    .HasConstraintName("FK_BasicCheckList_Resoult");

                entity.HasOne(d => d.Specifications)
                    .WithMany(p => p.BasicCheckList)
                    .HasForeignKey(d => d.SpecificationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BasicCheckList_Specifications");
            });

            modelBuilder.Entity<BasicDamage>(entity =>
            {
                entity.Property(e => e.BasicDamageId).HasColumnName("BasicDamageID");

                entity.Property(e => e.BasicDamageDescription).HasMaxLength(1000);

                entity.Property(e => e.BasicDamageDescriptionText).HasMaxLength(1000);

                entity.Property(e => e.BasicDamageExt).HasMaxLength(800);

                entity.Property(e => e.BasicDamageName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsActual)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<BoltedJoint>(entity =>
            {
                entity.Property(e => e.BoltedJointId).HasColumnName("BoltedJointID");

                entity.Property(e => e.AnchorAverageValue).HasColumnType("decimal(12, 1)");

                entity.Property(e => e.AnchorAverageValueString).HasMaxLength(10);

                entity.Property(e => e.AnchorValues)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FrameAverageValue).HasColumnType("decimal(12, 1)");

                entity.Property(e => e.FrameAverageValueString).HasMaxLength(10);

                entity.Property(e => e.FrameValues)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.SpecificationsId).HasColumnName("SpecificationsID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Resoult)
                    .WithMany(p => p.BoltedJoint)
                    .HasForeignKey(d => d.ResoultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoltedJoint_Resoult1");

                entity.HasOne(d => d.Specifications)
                    .WithMany(p => p.BoltedJoint)
                    .HasForeignKey(d => d.SpecificationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BoltedJoint_Specifications1");
            });

            modelBuilder.Entity<CheckList>(entity =>
            {
                entity.Property(e => e.CheckListId).HasColumnName("CheckListID");

                entity.Property(e => e.CheckListCriteriaId).HasColumnName("CheckListCriteriaID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.SelectedTilesIds)
                    .HasColumnName("SelectedTilesIDs")
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CheckListCriteria)
                    .WithMany(p => p.CheckList)
                    .HasForeignKey(d => d.CheckListCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckList_CheckListCriteria");
            });

            modelBuilder.Entity<CheckListCriteria>(entity =>
            {
                entity.Property(e => e.CheckListCriteriaId)
                    .HasColumnName("CheckListCriteriaID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CriteriaName)
                    .IsRequired()
                    .HasMaxLength(180);
            });

            modelBuilder.Entity<CheckListCriteriesTile>(entity =>
            {
                entity.Property(e => e.CheckListCriteriesTileId).HasColumnName("CheckListCriteriesTileID");

                entity.Property(e => e.CheckListCriteriaId).HasColumnName("CheckListCriteriaID");

                entity.Property(e => e.CheckListTileId).HasColumnName("CheckListTileID");

                entity.HasOne(d => d.CheckListTile)
                    .WithMany(p => p.CheckListCriteriesTile)
                    .HasForeignKey(d => d.CheckListTileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckListCriteriesTile_CheckListTile");
            });

            modelBuilder.Entity<CheckListRecomendation>(entity =>
            {
                entity.Property(e => e.CheckListRecomendationId).HasColumnName("CheckListRecomendationID");

                entity.Property(e => e.RecomendationId).HasColumnName("RecomendationID");

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.HasOne(d => d.Recomendation)
                    .WithMany(p => p.CheckListRecomendation)
                    .HasForeignKey(d => d.RecomendationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckListRecomendation_Recomendation");
            });

            modelBuilder.Entity<CheckListTile>(entity =>
            {
                entity.Property(e => e.CheckListTileId)
                    .HasColumnName("CheckListTileID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CheckListTileName)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.CityName)
                    .HasName("uq_CityName")
                    .IsUnique();

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientLicense>(entity =>
            {
                entity.Property(e => e.ClientLicenseId).HasColumnName("ClientLicenseID");

                entity.Property(e => e.LicenseId).HasColumnName("LicenseID");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.License)
                    .WithMany(p => p.ClientLicense)
                    .HasForeignKey(d => d.LicenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientLicense_Licenses");
            });

            modelBuilder.Entity<ClientSchemePermissions>(entity =>
            {
                entity.HasKey(e => e.ClientSchemePermissionId);

                entity.Property(e => e.ClientSchemePermissionId).HasColumnName("ClientSchemePermissionID");

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Resoult)
                    .WithMany(p => p.ClientSchemePermissions)
                    .HasForeignKey(d => d.ResoultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientSchemePermissions_Resoult");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Conclusion>(entity =>
            {
                entity.Property(e => e.ConclusionId).HasColumnName("ConclusionID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ExpertConclusion).IsUnicode(false);

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.TechnicalWriterConclusion).IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConclusionPart>(entity =>
            {
                entity.Property(e => e.ConclusionPartId).HasColumnName("ConclusionPartID");

                entity.Property(e => e.ConclusionRow).IsRequired();

                entity.Property(e => e.ConclusionRowName)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Connection>(entity =>
            {
                entity.HasKey(e => e.ConnetionKey);

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ExperyDate).HasColumnType("datetime");

                entity.Property(e => e.UserKey)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Wkey).HasColumnName("WKey");
            });

            modelBuilder.Entity<Control>(entity =>
            {
                entity.HasIndex(e => e.ProjectNumber)
                    .HasName("uq_ProjectNumber")
                    .IsUnique();

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.ClientDocuments).HasMaxLength(300);

                entity.Property(e => e.ContactPersonData).HasMaxLength(500);

                entity.Property(e => e.ControlData).HasColumnType("datetime");

                entity.Property(e => e.ControlEndData).HasColumnType("datetime");

                entity.Property(e => e.ControlName).HasMaxLength(300);

                entity.Property(e => e.DirectiveNumber).HasMaxLength(30);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeesList)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Foundation).HasMaxLength(300);

                entity.Property(e => e.MetodId).HasColumnName("MetodID");

                entity.Property(e => e.ParentProjectNumber).HasMaxLength(100);

                entity.Property(e => e.ParentRid).HasColumnName("ParentRID");

                entity.Property(e => e.ProjectComment).HasMaxLength(200);

                entity.Property(e => e.ProjectNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WarhouseId).HasColumnName("WarhouseID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Control)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Control__Employe__30F848ED");

                entity.HasOne(d => d.Metod)
                    .WithMany(p => p.Control)
                    .HasForeignKey(d => d.MetodId)
                    .HasConstraintName("FK__Control__MetodID__300424B4");

                entity.HasOne(d => d.Warhouse)
                    .WithMany(p => p.Control)
                    .HasForeignKey(d => d.WarhouseId)
                    .HasConstraintName("FK__Control__Warhous__2F10007B");
            });

            modelBuilder.Entity<ControlEmployees>(entity =>
            {
                entity.HasKey(e => e.ControlEmployeeId);

                entity.Property(e => e.ControlEmployeeId).HasColumnName("ControlEmployeeID");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.ControlEmployees)
                    .HasForeignKey(d => d.ControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ControlEmployees_Control");
            });

            modelBuilder.Entity<ControlMetod>(entity =>
            {
                entity.HasKey(e => e.MetodId)
                    .HasName("PK__ControlM__A5A1A9F6396DE1BF");

                entity.Property(e => e.MetodId).HasColumnName("MetodID");

                entity.Property(e => e.InspectionMetod)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlProgram>(entity =>
            {
                entity.Property(e => e.ControlProgramId).HasColumnName("ControlProgramID");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.ControlProgramElementId).HasColumnName("ControlProgramElementID");

                entity.Property(e => e.ElementValue).HasMaxLength(50);

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.ControlProgram)
                    .HasForeignKey(d => d.ControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ControlProgram_ControlID");

                entity.HasOne(d => d.ControlProgramElement)
                    .WithMany(p => p.ControlProgram)
                    .HasForeignKey(d => d.ControlProgramElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ControlProgram_ControlProgramElement");
            });

            modelBuilder.Entity<ControlProgramElement>(entity =>
            {
                entity.Property(e => e.ControlProgramElementId).HasColumnName("ControlProgramElementID");

                entity.Property(e => e.ControlProgramDescrption).HasMaxLength(250);

                entity.Property(e => e.ControlProgramName).HasMaxLength(80);
            });

            modelBuilder.Entity<DefectType>(entity =>
            {
                entity.HasKey(e => e.DefectId)
                    .HasName("PK__DefectTy__144A37FCF4B6E829");

                entity.Property(e => e.DefectId).HasColumnName("DefectID");

                entity.Property(e => e.DefectName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Deviation>(entity =>
            {
                entity.Property(e => e.DeviationId).HasColumnName("DeviationID");

                entity.Property(e => e.DeviationLocationId).HasColumnName("DeviationLocationID");

                entity.Property(e => e.DeviationOrientationId).HasColumnName("DeviationOrientationID");

                entity.Property(e => e.DeviationPlateLocationId).HasColumnName("DeviationPlateLocationID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FrameRange)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MRotation)
                    .HasColumnName("mRotation")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MScale)
                    .HasColumnName("mScale")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MX)
                    .HasColumnName("mX")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MY)
                    .HasColumnName("mY")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.Row)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificationsId).HasColumnName("SpecificationsID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.DeviationLocation)
                    .WithMany(p => p.Deviation)
                    .HasForeignKey(d => d.DeviationLocationId)
                    .HasConstraintName("FK_Deviation_DeviationLocation");

                entity.HasOne(d => d.DeviationOrientation)
                    .WithMany(p => p.Deviation)
                    .HasForeignKey(d => d.DeviationOrientationId)
                    .HasConstraintName("FK_Deviation_DeviationOrientation");

                entity.HasOne(d => d.DeviationPlateLocation)
                    .WithMany(p => p.Deviation)
                    .HasForeignKey(d => d.DeviationPlateLocationId)
                    .HasConstraintName("FK_Deviation_DeviationPlateLocation");

                entity.HasOne(d => d.Resoult)
                    .WithMany(p => p.Deviation)
                    .HasForeignKey(d => d.ResoultId)
                    .HasConstraintName("FK_Deviation_Resoult");

                entity.HasOne(d => d.Specifications)
                    .WithMany(p => p.Deviation)
                    .HasForeignKey(d => d.SpecificationsId)
                    .HasConstraintName("FK_Deviation_Specifications");
            });

            modelBuilder.Entity<DeviationLocation>(entity =>
            {
                entity.Property(e => e.DeviationLocationId).HasColumnName("DeviationLocationID");

                entity.Property(e => e.DeviationLocationName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviationOrientation>(entity =>
            {
                entity.Property(e => e.DeviationOrientationId).HasColumnName("DeviationOrientationID");

                entity.Property(e => e.DeviationOrientationName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviationPlateLocation>(entity =>
            {
                entity.Property(e => e.DeviationPlateLocationId).HasColumnName("DeviationPlateLocationID");

                entity.Property(e => e.DeviationPlateLocationName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentPath)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");
            });

            modelBuilder.Entity<Element>(entity =>
            {
                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ElementName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FullName).HasMaxLength(300);

                entity.Property(e => e.IsClient).HasColumnName("isClient");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserKey).HasMaxLength(128);
            });

            modelBuilder.Entity<EmployeeConnection>(entity =>
            {
                entity.HasKey(e => e.EmployeeConnectionKey);

                entity.Property(e => e.Ekey).HasColumnName("EKey");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ExperyDate).HasColumnType("datetime");

                entity.Property(e => e.UserKey)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpertCommission>(entity =>
            {
                entity.Property(e => e.ExpertCommissionId).HasColumnName("ExpertCommissionID");

                entity.Property(e => e.CertificationNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationBackSide)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificationFrontSide)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QualificationLevel)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ExpertCommission)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Empl_Expert");
            });

            modelBuilder.Entity<JornalCategory>(entity =>
            {
                entity.Property(e => e.JornalCategoryId).HasColumnName("JornalCategoryID");

                entity.Property(e => e.JornalCategoryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.JornalCategory)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_JornalCategory_Warhouse");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.JournalCategoryId).HasColumnName("JournalCategoryID");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.HasOne(d => d.JournalCategory)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.JournalCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Journal_JornalCategory");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Journal_Warhouse");
            });

            modelBuilder.Entity<Licenses>(entity =>
            {
                entity.HasKey(e => e.LicenseId);

                entity.Property(e => e.LicenseId).HasColumnName("LicenseID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LicenseBestBefore).HasColumnType("datetime");

                entity.Property(e => e.LicenseDocument).HasMaxLength(500);

                entity.Property(e => e.ParentLicenseId).HasColumnName("ParentLicenseID");

                entity.Property(e => e.WarhouseId).HasColumnName("WarhouseID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Licenses)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Licenses_Company");

                entity.HasOne(d => d.Warhouse)
                    .WithMany(p => p.Licenses)
                    .HasForeignKey(d => d.WarhouseId)
                    .HasConstraintName("FK_Licenses_Warhouse");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.EventDateTime).HasColumnType("datetime");

                entity.Property(e => e.EventInfo).HasMaxLength(300);

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.QueryString).HasMaxLength(80);

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.ShortUserId).HasColumnName("ShortUserID");

                entity.Property(e => e.UserIpaddress)
                    .HasColumnName("UserIPaddress")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Map>(entity =>
            {
                entity.HasIndex(e => new { e.MapUnit, e.FrameString, e.X })
                    .HasName("t1");

                entity.Property(e => e.MapId).HasColumnName("MapID");

                entity.Property(e => e.CIndex).HasColumnName("cIndex");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FrameString).HasMaxLength(16);

                entity.Property(e => e.Height).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MapUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Row)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificationsId).HasColumnName("SpecificationsID");

                entity.Property(e => e.Width).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.X).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Y).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.СLevel)
                    .HasColumnName("сLevel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Specifications)
                    .WithMany(p => p.Map)
                    .HasForeignKey(d => d.SpecificationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MAP_SpecificationsID_1");
            });

            modelBuilder.Entity<NuevoExpertComission>(entity =>
            {
                entity.Property(e => e.NuevoExpertComissionId).HasColumnName("NuevoExpertComissionID");

                entity.Property(e => e.CertificationNumber).HasMaxLength(300);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.QualificationLevel)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Orientation>(entity =>
            {
                entity.Property(e => e.OrientationId)
                    .HasColumnName("OrientationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Orientation1)
                    .HasColumnName("Orientation")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.Property(e => e.PageId)
                    .HasColumnName("PageID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PageAddress).HasMaxLength(30);

                entity.Property(e => e.PageName).HasMaxLength(40);
            });

            modelBuilder.Entity<PartialTo>(entity =>
            {
                entity.ToTable("PartialTO");

                entity.Property(e => e.PartialToid).HasColumnName("PartialTOID");

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.PartialTodate)
                    .HasColumnName("PartialTODate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WarhouseId).HasColumnName("WarhouseID");

                entity.HasOne(d => d.Resoult)
                    .WithMany(p => p.PartialTo)
                    .HasForeignKey(d => d.ResoultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartialTO_Resoult");

                entity.HasOne(d => d.Warhouse)
                    .WithMany(p => p.PartialTo)
                    .HasForeignKey(d => d.WarhouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartialTO_Warhouse");
            });

            modelBuilder.Entity<PhotoType>(entity =>
            {
                entity.Property(e => e.PhotoTypeId)
                    .HasColumnName("PhotoTypeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PhotoTypeName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Photomaterial>(entity =>
            {
                entity.Property(e => e.PhotomaterialId).HasColumnName("PhotomaterialID");

                entity.Property(e => e.BasicCheckListId).HasColumnName("BasicCheckListID");

                entity.Property(e => e.Photo).IsRequired();

                entity.Property(e => e.PhotoTypeId).HasColumnName("PhotoTypeID");

                entity.Property(e => e.PhotoСaption)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.HasOne(d => d.BasicCheckList)
                    .WithMany(p => p.Photomaterial)
                    .HasForeignKey(d => d.BasicCheckListId)
                    .HasConstraintName("FK_Photomaterial_BasicCheckList");

                entity.HasOne(d => d.PhotoType)
                    .WithMany(p => p.Photomaterial)
                    .HasForeignKey(d => d.PhotoTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photomaterial_PhotoType");
            });

            modelBuilder.Entity<Recomendation>(entity =>
            {
                entity.Property(e => e.RecomendationId)
                    .HasColumnName("RecomendationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsGost).HasColumnName("IsGOST");

                entity.Property(e => e.RecomendationName)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Resoult>(entity =>
            {
                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.Resoult)
                    .HasForeignKey(d => d.ControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Resoult__Control__33D4B598");
            });

            modelBuilder.Entity<RiskLevel>(entity =>
            {
                entity.Property(e => e.RiskLevelId).HasColumnName("RiskLevelID");

                entity.Property(e => e.RiscLevelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Safety>(entity =>
            {
                entity.Property(e => e.SafetyId).HasColumnName("SafetyID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InspectedBy).HasMaxLength(100);

                entity.Property(e => e.ResponsiblePerson).HasMaxLength(100);

                entity.Property(e => e.WarhouseId).HasColumnName("WarhouseID");

                entity.HasOne(d => d.Warhouse)
                    .WithMany(p => p.Safety)
                    .HasForeignKey(d => d.WarhouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Safety_Warhouse");
            });

            modelBuilder.Entity<SafetyList>(entity =>
            {
                entity.Property(e => e.SafetyListId).HasColumnName("SafetyListID");

                entity.Property(e => e.SafetyId).HasColumnName("SafetyID");

                entity.Property(e => e.SafetyListCriteriaId).HasColumnName("SafetyListCriteriaID");

                entity.HasOne(d => d.SafetyListCriteria)
                    .WithMany(p => p.SafetyList)
                    .HasForeignKey(d => d.SafetyListCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SafetyList_SafetyListCriteria");
            });

            modelBuilder.Entity<SafetyListCategory>(entity =>
            {
                entity.Property(e => e.SafetyListCategoryId).HasColumnName("SafetyListCategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.WarhouseId).HasColumnName("WarhouseID");

                entity.HasOne(d => d.Warhouse)
                    .WithMany(p => p.SafetyListCategory)
                    .HasForeignKey(d => d.WarhouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SafetyListCategory_Warhouse");
            });

            modelBuilder.Entity<SafetyListCriteria>(entity =>
            {
                entity.Property(e => e.SafetyListCriteriaId).HasColumnName("SafetyListCriteriaID");

                entity.Property(e => e.CriteriaName).HasMaxLength(100);

                entity.Property(e => e.SafetyListCategoryId).HasColumnName("SafetyListCategoryID");

                entity.HasOne(d => d.SafetyListCategory)
                    .WithMany(p => p.SafetyListCriteria)
                    .HasForeignKey(d => d.SafetyListCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SafetyListCriteria_SafetyListCategory");
            });

            modelBuilder.Entity<ShortUser>(entity =>
            {
                entity.Property(e => e.ShortUserId).HasColumnName("ShortUserID");

                entity.Property(e => e.Test).HasMaxLength(10);

                entity.Property(e => e.UserKey)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Specifications>(entity =>
            {
                entity.Property(e => e.SpecificationsId).HasColumnName("SpecificationsID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ManufacturedStillage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.StillageTypeId).HasColumnName("StillageTypeID");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WarhouseId).HasColumnName("WarhouseID");

                entity.HasOne(d => d.StillageType)
                    .WithMany(p => p.Specifications)
                    .HasForeignKey(d => d.StillageTypeId)
                    .HasConstraintName("FK__Specifica__Still__35BCFE0A");

                entity.HasOne(d => d.Warhouse)
                    .WithMany(p => p.Specifications)
                    .HasForeignKey(d => d.WarhouseId)
                    .HasConstraintName("FK_Warhouse_WarhouseID_1");
            });

            modelBuilder.Entity<SpecificationsElement>(entity =>
            {
                entity.Property(e => e.SpecificationsElementId).HasColumnName("SpecificationsElementID");

                entity.Property(e => e.BarName)
                    .HasColumnName("barName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarType).HasColumnName("barType");

                entity.Property(e => e.EA)
                    .HasColumnName("eA")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EB)
                    .HasColumnName("eB")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EC)
                    .HasColumnName("eC")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EH)
                    .HasColumnName("eH")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EL)
                    .HasColumnName("eL")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ElementSize)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Era)
                    .HasColumnName("era")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Erb)
                    .HasColumnName("erb")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FD)
                    .HasColumnName("fD")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FE)
                    .HasColumnName("fE")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FHlevelLowerMin).HasColumnName("fHLevelLowerMin");

                entity.Property(e => e.FLevelCount).HasColumnName("fLevelCount");

                entity.Property(e => e.FLevelDistanceMax).HasColumnName("fLevelDistanceMax");

                entity.Property(e => e.FНlevelLowerMax).HasColumnName("fНLevelLowerMax");

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.SpecificationsId).HasColumnName("SpecificationsID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Element)
                    .WithMany(p => p.SpecificationsElement)
                    .HasForeignKey(d => d.ElementId)
                    .HasConstraintName("R_1");

                entity.HasOne(d => d.Resoult)
                    .WithMany(p => p.SpecificationsElement)
                    .HasForeignKey(d => d.ResoultId)
                    .HasConstraintName("FK_ResoultID_1");

                entity.HasOne(d => d.Specifications)
                    .WithMany(p => p.SpecificationsElement)
                    .HasForeignKey(d => d.SpecificationsId)
                    .HasConstraintName("R_2");
            });

            modelBuilder.Entity<StillageTest>(entity =>
            {
                entity.Property(e => e.StillageTestId).HasColumnName("StillageTestID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Frame).HasMaxLength(12);

                entity.Property(e => e.FrameElementId).HasColumnName("FrameElementID");

                entity.Property(e => e.IsLoaded).HasColumnName("isLoaded");

                entity.Property(e => e.LevelCount).HasColumnName("levelCount");

                entity.Property(e => e.LoadElementId).HasColumnName("LoadElementID");

                entity.Property(e => e.MapId).HasColumnName("MapID");

                entity.Property(e => e.ResoultId).HasColumnName("ResoultID");

                entity.Property(e => e.Row).HasMaxLength(20);

                entity.Property(e => e.SpecificationsId).HasColumnName("SpecificationsID");

                entity.Property(e => e.StillageTestDate).HasColumnType("datetime");

                entity.Property(e => e.StoikaElementId).HasColumnName("StoikaElementID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.FrameElement)
                    .WithMany(p => p.StillageTestFrameElement)
                    .HasForeignKey(d => d.FrameElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StillageTest_SpecificationsElement2");

                entity.HasOne(d => d.LoadElement)
                    .WithMany(p => p.StillageTestLoadElement)
                    .HasForeignKey(d => d.LoadElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StillageTest_SpecificationsElement");

                entity.HasOne(d => d.Map)
                    .WithMany(p => p.StillageTest)
                    .HasForeignKey(d => d.MapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StillageTest_Map");

                entity.HasOne(d => d.Resoult)
                    .WithMany(p => p.StillageTest)
                    .HasForeignKey(d => d.ResoultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StillageTest_Resoult");

                entity.HasOne(d => d.Specifications)
                    .WithMany(p => p.StillageTest)
                    .HasForeignKey(d => d.SpecificationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StillageTest_Specifications");

                entity.HasOne(d => d.StoikaElement)
                    .WithMany(p => p.StillageTestStoikaElement)
                    .HasForeignKey(d => d.StoikaElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StillageTest_SpecificationsElement1");
            });

            modelBuilder.Entity<StillageType>(entity =>
            {
                entity.Property(e => e.StillageTypeId).HasColumnName("StillageTypeID");

                entity.Property(e => e.StillageTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockElements>(entity =>
            {
                entity.Property(e => e.StockElementsId).HasColumnName("StockElementsID");

                entity.Property(e => e.SpecificationsElementId).HasColumnName("SpecificationsElementID");

                entity.Property(e => e.SpecificationsId).HasColumnName("SpecificationsID");

                entity.Property(e => e.WarhouseId).HasColumnName("WarhouseID");

                entity.HasOne(d => d.Specifications)
                    .WithMany(p => p.StockElements)
                    .HasForeignKey(d => d.SpecificationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockElements_SpecificationsElement");

                entity.HasOne(d => d.Warhouse)
                    .WithMany(p => p.StockElements)
                    .HasForeignKey(d => d.WarhouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockElements_Warhouse");
            });

            modelBuilder.Entity<Support>(entity =>
            {
                entity.Property(e => e.SupportId).HasColumnName("SupportID");

                entity.Property(e => e.Answer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Support)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Support__Employe__37A5467C");
            });

            modelBuilder.Entity<Vik>(entity =>
            {
                entity.Property(e => e.VikId).HasColumnName("VikID");

                entity.Property(e => e.CComment)
                    .HasColumnName("cComment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DefectId).HasColumnName("DefectID");

                entity.Property(e => e.ElementOrientation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FrameRange)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MRotation)
                    .HasColumnName("mRotation")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MScale).HasColumnName("mScale");

                entity.Property(e => e.MX)
                    .HasColumnName("mX")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MY)
                    .HasColumnName("mY")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NLevel)
                    .IsRequired()
                    .HasColumnName("nLevel")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalVikId).HasColumnName("OriginalVikID");

                entity.Property(e => e.Otkmark).HasColumnName("OTKmark");

                entity.Property(e => e.PartialToid).HasColumnName("PartialTOID");

                entity.Property(e => e.RiskLevelId).HasColumnName("RiskLevelID");

                entity.Property(e => e.Row)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecificationsElementId).HasColumnName("SpecificationsElementID");

                entity.Property(e => e.StructuralMemberId).HasColumnName("StructuralMemberID");

                entity.Property(e => e.UniqueId).HasColumnName("UniqueID");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Defect)
                    .WithMany(p => p.Vik)
                    .HasForeignKey(d => d.DefectId)
                    .HasConstraintName("FK__Vik__DefectID__398D8EEE");

                entity.HasOne(d => d.PartialTo)
                    .WithMany(p => p.Vik)
                    .HasForeignKey(d => d.PartialToid)
                    .HasConstraintName("FK_Vik_PartialTO");

                entity.HasOne(d => d.RiskLevel)
                    .WithMany(p => p.Vik)
                    .HasForeignKey(d => d.RiskLevelId)
                    .HasConstraintName("FK__Vik__RiskLevelID__3B75D760");

                entity.HasOne(d => d.SpecificationsElement)
                    .WithMany(p => p.Vik)
                    .HasForeignKey(d => d.SpecificationsElementId)
                    .HasConstraintName("R_6");

                entity.HasOne(d => d.StructuralMember)
                    .WithMany(p => p.Vik)
                    .HasForeignKey(d => d.StructuralMemberId)
                    .HasConstraintName("FK__Vik__StructuralM__38996AB5");
            });

            modelBuilder.Entity<VikElement>(entity =>
            {
                entity.HasKey(e => e.StructuralMemberId)
                    .HasName("PK__VikEleme__3EAEA9BA03F1F096");

                entity.Property(e => e.StructuralMemberId).HasColumnName("StructuralMemberID");

                entity.Property(e => e.StructuralMemberName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Warhouse>(entity =>
            {
                entity.Property(e => e.WarhouseId).HasColumnName("WarhouseID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.WarhouseAddress).HasMaxLength(300);

                entity.Property(e => e.WarhouseName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Warhouse)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__Warhouse__CityID__3D5E1FD2");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Warhouse)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__Warhouse__Compan__3C69FB99");
            });
        }
    }
}
