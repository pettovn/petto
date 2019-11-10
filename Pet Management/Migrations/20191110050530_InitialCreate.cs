using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pet_Management.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DPETTYPE",
                columns: table => new
                {
                    d_type_id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    d_type_name = table.Column<string>(nullable: false),
                    m_type_id = table.Column<short>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPETTYPE", x => x.d_type_id);
                });

            migrationBuilder.CreateTable(
                name: "HEALTHCARE",
                columns: table => new
                {
                    healthcare_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    place = table.Column<string>(nullable: true),
                    pet_id = table.Column<long>(nullable: false),
                    service_id = table.Column<short>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HEALTHCARE", x => x.healthcare_id);
                });

            migrationBuilder.CreateTable(
                name: "IMAGE",
                columns: table => new
                {
                    image_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image_name = table.Column<string>(nullable: false),
                    path = table.Column<string>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMAGE", x => x.image_id);
                });

            migrationBuilder.CreateTable(
                name: "MCITY",
                columns: table => new
                {
                    city_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCITY", x => x.city_id);
                });

            migrationBuilder.CreateTable(
                name: "MDISTRICT",
                columns: table => new
                {
                    district_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city_id = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MDISTRICT", x => x.district_id);
                });

            migrationBuilder.CreateTable(
                name: "MFURCOLOR",
                columns: table => new
                {
                    color_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    color_name = table.Column<string>(nullable: true),
                    avatar = table.Column<long>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MFURCOLOR", x => x.color_id);
                });

            migrationBuilder.CreateTable(
                name: "MPETTYPE",
                columns: table => new
                {
                    m_type_id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    m_type_name = table.Column<string>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPETTYPE", x => x.m_type_id);
                });

            migrationBuilder.CreateTable(
                name: "MSERVICE",
                columns: table => new
                {
                    checkID = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    checkName = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSERVICE", x => x.checkID);
                });

            migrationBuilder.CreateTable(
                name: "MWARD",
                columns: table => new
                {
                    ward_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    district_id = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MWARD", x => x.ward_id);
                });

            migrationBuilder.CreateTable(
                name: "PET",
                columns: table => new
                {
                    petID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    petName = table.Column<string>(nullable: true),
                    birthday = table.Column<DateTime>(nullable: false),
                    gender = table.Column<short>(nullable: false),
                    price = table.Column<decimal>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    color = table.Column<long>(nullable: false),
                    owner = table.Column<long>(nullable: false),
                    father = table.Column<long>(nullable: false),
                    mother = table.Column<long>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PET", x => x.petID);
                });

            migrationBuilder.CreateTable(
                name: "PET_IMG",
                columns: table => new
                {
                    pet_id = table.Column<long>(nullable: false),
                    img_id = table.Column<long>(nullable: false),
                    service_id = table.Column<long>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PET_IMG", x => new { x.pet_id, x.img_id });
                    table.UniqueConstraint("AK_PET_IMG_img_id_pet_id", x => new { x.img_id, x.pet_id });
                });

            migrationBuilder.CreateTable(
                name: "PURCHASE",
                columns: table => new
                {
                    purchase_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: false),
                    number = table.Column<short>(nullable: false),
                    price = table.Column<decimal>(nullable: false),
                    address = table.Column<string>(nullable: false),
                    note = table.Column<string>(nullable: true),
                    seller = table.Column<long>(nullable: false),
                    pet_id = table.Column<long>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURCHASE", x => x.purchase_id);
                });

            migrationBuilder.CreateTable(
                name: "PURCHASE_IMG",
                columns: table => new
                {
                    purchase_id = table.Column<long>(nullable: false),
                    img_id = table.Column<long>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURCHASE_IMG", x => new { x.purchase_id, x.img_id });
                    table.UniqueConstraint("AK_PURCHASE_IMG_img_id_purchase_id", x => new { x.img_id, x.purchase_id });
                });

            migrationBuilder.CreateTable(
                name: "SCHEDULE",
                columns: table => new
                {
                    schedule_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schedule_time = table.Column<DateTime>(nullable: false),
                    content = table.Column<string>(nullable: false),
                    pet_id = table.Column<long>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHEDULE", x => x.schedule_id);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    user_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(nullable: false),
                    phone = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    birthday = table.Column<DateTime>(nullable: false),
                    gender = table.Column<short>(nullable: false),
                    facebook = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: false),
                    classification = table.Column<short>(nullable: false),
                    role = table.Column<short>(nullable: false),
                    status = table.Column<short>(nullable: false),
                    avatar = table.Column<long>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "VIDEO",
                columns: table => new
                {
                    vid_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vid_name = table.Column<string>(nullable: false),
                    path = table.Column<string>(nullable: false),
                    crt_usr = table.Column<long>(nullable: false),
                    crt_dt = table.Column<DateTime>(nullable: false),
                    upd_usr = table.Column<long>(nullable: false),
                    upd_dt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIDEO", x => x.vid_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DPETTYPE");

            migrationBuilder.DropTable(
                name: "HEALTHCARE");

            migrationBuilder.DropTable(
                name: "IMAGE");

            migrationBuilder.DropTable(
                name: "MCITY");

            migrationBuilder.DropTable(
                name: "MDISTRICT");

            migrationBuilder.DropTable(
                name: "MFURCOLOR");

            migrationBuilder.DropTable(
                name: "MPETTYPE");

            migrationBuilder.DropTable(
                name: "MSERVICE");

            migrationBuilder.DropTable(
                name: "MWARD");

            migrationBuilder.DropTable(
                name: "PET");

            migrationBuilder.DropTable(
                name: "PET_IMG");

            migrationBuilder.DropTable(
                name: "PURCHASE");

            migrationBuilder.DropTable(
                name: "PURCHASE_IMG");

            migrationBuilder.DropTable(
                name: "SCHEDULE");

            migrationBuilder.DropTable(
                name: "USER");

            migrationBuilder.DropTable(
                name: "VIDEO");
        }
    }
}
