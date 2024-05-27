﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PAYROL_SYSTEM.Context;

namespace PAYROL_SYSTEM.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240506065744_senebthh")]
    partial class senebthh
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PAYROL_SYSTEM.Models.AllowancePayment_Transactions", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("strAllowanvcetypeId")
                        .IsRequired();

                    b.Property<double>("strAmount");

                    b.Property<DateTime>("strDate");

                    b.Property<int>("strPaidStatus");

                    b.Property<string>("strUserId")
                        .IsRequired();

                    b.HasKey("strId");

                    b.ToTable("allowancePayment_Transactions");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.Allowance_Type", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("strAllowanceTypeName")
                        .IsRequired();

                    b.Property<double>("strSalary_Rate");

                    b.HasKey("strId");

                    b.ToTable("GetAllowance_Types");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.Allowances", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("strAllowanceId");

                    b.Property<string>("strUserId")
                        .IsRequired();

                    b.HasKey("strId");

                    b.ToTable("Allowances");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.Commission", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<double>("strAmount");

                    b.Property<DateTime>("strDate");

                    b.Property<int>("strPaidStatus");

                    b.Property<string>("strUserId")
                        .IsRequired();

                    b.HasKey("strId");

                    b.ToTable("Commissions");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.Departments", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("strDepartmentId")
                        .IsRequired();

                    b.HasKey("strId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.Designation_Role", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("strDesignation_Role")
                        .IsRequired();

                    b.HasKey("strId");

                    b.ToTable("designation_Roles");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.Employees", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("strAccountNo");

                    b.Property<int>("strActive_Status");

                    b.Property<string>("strBank_Name");

                    b.Property<double>("strBasicSalary");

                    b.Property<DateTime>("strDateOfBirth");

                    b.Property<DateTime>("strDate_Of_Join");

                    b.Property<string>("strDetartmentId");

                    b.Property<string>("strEmail");

                    b.Property<string>("strFullName")
                        .IsRequired();

                    b.Property<int>("strGender");

                    b.Property<string>("strIdKRAPIN")
                        .IsRequired();

                    b.Property<string>("strIdNo")
                        .IsRequired();

                    b.Property<string>("strJobGroupId")
                        .IsRequired();

                    b.Property<double>("strLoan");

                    b.Property<int>("strMarital_Status");

                    b.Property<string>("strNHIF_No");

                    b.Property<string>("strNSSF_NO");

                    b.Property<double>("strPenalties");

                    b.Property<string>("strPhoneNo");

                    b.Property<string>("strReligion");

                    b.Property<string>("strRole")
                        .IsRequired();

                    b.Property<double>("strSacco_Deductyion");

                    b.Property<string>("strStaff_No");

                    b.HasKey("strId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.Job_Groups", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<double>("strBasicSalary");

                    b.Property<string>("strGroupName")
                        .IsRequired();

                    b.Property<double>("strHouseLevy");

                    b.Property<double>("strNHIFDeduction");

                    b.Property<double>("strNSSFDeduction");

                    b.HasKey("strId");

                    b.ToTable("Job_Groups");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.OverTime", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<double>("strAmount");

                    b.Property<DateTime>("strDate");

                    b.Property<int>("strPaidStatus");

                    b.Property<string>("strUserId")
                        .IsRequired();

                    b.HasKey("strId");

                    b.ToTable("OverTimes");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.PaymentHistory", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<double>("strNHIF");

                    b.Property<double>("strNSSF");

                    b.Property<double>("strSalary");

                    b.Property<double>("strToTal_Allowances");

                    b.Property<double>("strToTal_Commission");

                    b.Property<double>("strToTal_Overtime");

                    b.Property<double>("strhOUSElEVVY");

                    b.Property<string>("struSERiD");

                    b.HasKey("strId");

                    b.ToTable("PaymentHistories");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.PayslipMonthlyInfo", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("stBankAccount")
                        .IsRequired();

                    b.Property<string>("strBankName")
                        .IsRequired();

                    b.Property<double>("strBasicSalary");

                    b.Property<string>("strDepartment")
                        .IsRequired();

                    b.Property<string>("strDesignation")
                        .IsRequired();

                    b.Property<string>("strFullName")
                        .IsRequired();

                    b.Property<double>("strHousingLevvy");

                    b.Property<bool>("strIsPaidStatus");

                    b.Property<string>("strJobGroup")
                        .IsRequired();

                    b.Property<string>("strMonthYear")
                        .IsRequired();

                    b.Property<double>("strNHIF");

                    b.Property<double>("strNSSF");

                    b.Property<double>("strSaccoDeduction");

                    b.Property<double>("strTotalAllowance");

                    b.Property<double>("strTotalCommission");

                    b.Property<double>("strTotalOvertime");

                    b.Property<string>("strUserId")
                        .IsRequired();

                    b.HasKey("strId");

                    b.ToTable("payslipMonthlyInfos");
                });

            modelBuilder.Entity("PAYROL_SYSTEM.Models.Users", b =>
                {
                    b.Property<string>("strId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("strFullName")
                        .IsRequired();

                    b.Property<string>("strPassword")
                        .IsRequired();

                    b.Property<string>("strRole")
                        .IsRequired();

                    b.Property<string>("strUsername")
                        .IsRequired();

                    b.HasKey("strId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
