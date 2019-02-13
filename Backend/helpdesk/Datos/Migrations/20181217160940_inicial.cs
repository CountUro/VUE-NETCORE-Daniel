using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Datos.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "consecutivo_hd",
                columns: table => new
                {
                    consecutivo_hd_id = table.Column<int>(nullable: false),
                    consecutivo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consecutivo_hd", x => x.consecutivo_hd_id);
                });

            migrationBuilder.CreateTable(
                name: "dominio",
                columns: table => new
                {
                    dominio_id = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dominio", x => x.dominio_id);
                });

            migrationBuilder.CreateTable(
                name: "grupo_cia",
                columns: table => new
                {
                    grupo_cia_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupo_cia", x => x.grupo_cia_id);
                });

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    pais_id = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(maxLength: 150, nullable: false),
                    nombre_completo = table.Column<string>(maxLength: 150, nullable: false),
                    continente = table.Column<string>(maxLength: 20, nullable: false),
                    iso2 = table.Column<string>(maxLength: 4, nullable: false),
                    iso3 = table.Column<string>(maxLength: 4, nullable: false),
                    iso3166 = table.Column<string>(maxLength: 4, nullable: false),
                    cia = table.Column<string>(maxLength: 10, nullable: false),
                    telefono = table.Column<string>(maxLength: 20, nullable: false),
                    internet = table.Column<string>(maxLength: 4, nullable: false),
                    vehiculo = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.pais_id);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    rol_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.rol_id);
                });

            migrationBuilder.CreateTable(
                name: "soporte",
                columns: table => new
                {
                    soporte_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_soporte", x => x.soporte_id);
                });

            migrationBuilder.CreateTable(
                name: "dominio_det",
                columns: table => new
                {
                    dominio_det_id = table.Column<long>(nullable: false),
                    codigo = table.Column<short>(nullable: false, defaultValue: (short)0),
                    descripcion = table.Column<string>(maxLength: 100, nullable: false),
                    dominio_id = table.Column<int>(nullable: false),
                    pais_id = table.Column<int>(nullable: false),
                    descrip_corta = table.Column<string>(maxLength: 30, nullable: false),
                    signo = table.Column<int>(nullable: false, defaultValue: 0),
                    entero1 = table.Column<int>(nullable: false),
                    entero2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dominio_det", x => x.dominio_det_id);
                    table.ForeignKey(
                        name: "fk_dominiodet_dominio",
                        column: x => x.dominio_id,
                        principalTable: "dominio",
                        principalColumn: "dominio_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_dominiodet_pais",
                        column: x => x.pais_id,
                        principalTable: "pais",
                        principalColumn: "pais_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    estado_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 150, nullable: false),
                    pais_id = table.Column<int>(nullable: false),
                    codigo = table.Column<string>(maxLength: 6, nullable: true),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado", x => x.estado_id);
                    table.ForeignKey(
                        name: "fk_estado_pais",
                        column: x => x.pais_id,
                        principalTable: "pais",
                        principalColumn: "pais_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    usuario_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    email = table.Column<string>(maxLength: 150, nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    tlf_movil = table.Column<string>(maxLength: 20, nullable: true),
                    tlf_oficina = table.Column<string>(maxLength: 20, nullable: true),
                    f_login = table.Column<DateTime>(nullable: false),
                    token = table.Column<string>(maxLength: 1024, nullable: true),
                    programador = table.Column<bool>(nullable: false),
                    soporte_id = table.Column<int>(nullable: false),
                    pais_id = table.Column<int>(nullable: false),
                    rol_id = table.Column<int>(nullable: false),
                    password_hash = table.Column<byte[]>(nullable: false),
                    password_salt = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.usuario_id);
                    table.ForeignKey(
                        name: "fk_usuario_pais",
                        column: x => x.pais_id,
                        principalTable: "pais",
                        principalColumn: "pais_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_usuario_rol",
                        column: x => x.rol_id,
                        principalTable: "rol",
                        principalColumn: "rol_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_usuario_soporte",
                        column: x => x.soporte_id,
                        principalTable: "soporte",
                        principalColumn: "soporte_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    persona_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    cedula = table.Column<string>(maxLength: 15, nullable: false),
                    nombre1 = table.Column<string>(maxLength: 200, nullable: false),
                    nombre2 = table.Column<string>(maxLength: 100, nullable: true),
                    apellido1 = table.Column<string>(maxLength: 100, nullable: false),
                    apellido2 = table.Column<string>(maxLength: 100, nullable: true),
                    nombre_comp = table.Column<string>(maxLength: 200, nullable: false),
                    tlf_movil = table.Column<string>(maxLength: 20, nullable: true),
                    tlf_local = table.Column<string>(maxLength: 20, nullable: true),
                    email = table.Column<string>(maxLength: 150, nullable: true),
                    cargo = table.Column<string>(maxLength: 60, nullable: true),
                    sexo_6_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.persona_id);
                    table.ForeignKey(
                        name: "fk_persona_dd_sexo6",
                        column: x => x.sexo_6_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    ciudad_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 150, nullable: false),
                    codigo = table.Column<string>(maxLength: 6, nullable: true),
                    activo = table.Column<bool>(nullable: false),
                    estado_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudad", x => x.ciudad_id);
                    table.ForeignKey(
                        name: "fk_ciudad_estado",
                        column: x => x.estado_id,
                        principalTable: "estado",
                        principalColumn: "estado_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "municipio",
                columns: table => new
                {
                    municipio_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    estado_id = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    codigo = table.Column<string>(maxLength: 6, nullable: true),
                    referencia = table.Column<string>(maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipio", x => x.municipio_id);
                    table.ForeignKey(
                        name: "fk_municipio_estado",
                        column: x => x.estado_id,
                        principalTable: "estado",
                        principalColumn: "estado_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cia",
                columns: table => new
                {
                    cia_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    rif = table.Column<string>(maxLength: 20, nullable: false),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    grupo_cia_id = table.Column<int>(nullable: false),
                    tipo_166_id = table.Column<long>(nullable: false),
                    pais_id = table.Column<int>(nullable: false),
                    marca_87_id = table.Column<long>(nullable: false),
                    codigo_bd = table.Column<string>(maxLength: 12, nullable: false),
                    activa = table.Column<bool>(nullable: false),
                    bloqueada = table.Column<bool>(nullable: false),
                    f_aplica_bloqueo = table.Column<DateTime>(nullable: true),
                    lic_alquiler = table.Column<int>(nullable: false),
                    lic_vta = table.Column<int>(nullable: false),
                    version_app = table.Column<string>(maxLength: 8, nullable: false),
                    version_bd = table.Column<string>(maxLength: 8, nullable: false),
                    marca = table.Column<string>(maxLength: 60, nullable: true),
                    soporte_id = table.Column<int>(nullable: false),
                    ciudad_id = table.Column<int>(nullable: false),
                    estado_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cia", x => x.cia_id);
                    table.ForeignKey(
                        name: "fk_cia_ciudad",
                        column: x => x.ciudad_id,
                        principalTable: "ciudad",
                        principalColumn: "ciudad_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cia_estado",
                        column: x => x.estado_id,
                        principalTable: "estado",
                        principalColumn: "estado_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cia_grupoCia",
                        column: x => x.grupo_cia_id,
                        principalTable: "grupo_cia",
                        principalColumn: "grupo_cia_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cia_dd_marca87",
                        column: x => x.marca_87_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cia_pais",
                        column: x => x.pais_id,
                        principalTable: "pais",
                        principalColumn: "pais_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cia_soporte",
                        column: x => x.soporte_id,
                        principalTable: "soporte",
                        principalColumn: "soporte_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_cia_dd_166",
                        column: x => x.tipo_166_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hddoc",
                columns: table => new
                {
                    hd_doc_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    consultor_id = table.Column<int>(nullable: false),
                    programador_id = table.Column<int>(nullable: false),
                    cia_id = table.Column<int>(nullable: false),
                    persona_id = table.Column<int>(nullable: false),
                    pais_id = table.Column<int>(nullable: false),
                    aplicacion_178_id = table.Column<long>(nullable: false),
                    urgencia_170_id = table.Column<long>(nullable: false),
                    tipo_172_id = table.Column<long>(nullable: false),
                    status_175_id = table.Column<long>(nullable: false),
                    modulo_214_id = table.Column<long>(nullable: false),
                    motivo_298_id = table.Column<long>(nullable: false),
                    numero = table.Column<int>(nullable: false),
                    titulo = table.Column<string>(maxLength: 120, nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    f_crea = table.Column<DateTime>(nullable: false),
                    version_app = table.Column<string>(maxLength: 12, nullable: true),
                    version_bd = table.Column<string>(maxLength: 12, nullable: true),
                    f_correcion = table.Column<DateTime>(nullable: false),
                    solucion = table.Column<string>(type: "text", nullable: true),
                    version_solucion = table.Column<string>(maxLength: 12, nullable: true),
                    f_solucion = table.Column<DateTime>(nullable: false),
                    nombre_contacto = table.Column<string>(maxLength: 120, nullable: true),
                    email_contacto = table.Column<string>(maxLength: 150, nullable: true),
                    tlf_contacto = table.Column<string>(maxLength: 20, nullable: true),
                    nombre_ventana = table.Column<string>(maxLength: 60, nullable: true),
                    leido_consultor = table.Column<bool>(nullable: false),
                    leido_programador = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hddoc", x => x.hd_doc_id);
                    table.ForeignKey(
                        name: "fk_hddoc_dd_aplicacion178",
                        column: x => x.aplicacion_178_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_cia",
                        column: x => x.cia_id,
                        principalTable: "cia",
                        principalColumn: "cia_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_consultor",
                        column: x => x.consultor_id,
                        principalTable: "usuario",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_dd_modulo214",
                        column: x => x.modulo_214_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_dd_motivo298",
                        column: x => x.motivo_298_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_pais",
                        column: x => x.pais_id,
                        principalTable: "pais",
                        principalColumn: "pais_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_persona",
                        column: x => x.programador_id,
                        principalTable: "persona",
                        principalColumn: "persona_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_programador",
                        column: x => x.programador_id,
                        principalTable: "usuario",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_dd_status175",
                        column: x => x.status_175_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_dd_tipo172",
                        column: x => x.tipo_172_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hddoc_dd_consultor",
                        column: x => x.urgencia_170_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sucursal",
                columns: table => new
                {
                    sucursal_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nombre = table.Column<string>(maxLength: 100, nullable: false),
                    cia_id = table.Column<int>(nullable: false),
                    pais_id = table.Column<int>(nullable: false),
                    estado_id = table.Column<int>(nullable: false),
                    ciudad_id = table.Column<int>(nullable: false),
                    municipio_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sucursal", x => x.sucursal_id);
                    table.ForeignKey(
                        name: "fk_sucursal_cia",
                        column: x => x.cia_id,
                        principalTable: "cia",
                        principalColumn: "cia_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sucursal_ciudad",
                        column: x => x.ciudad_id,
                        principalTable: "ciudad",
                        principalColumn: "ciudad_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sucursal_estado",
                        column: x => x.estado_id,
                        principalTable: "estado",
                        principalColumn: "estado_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_sucursal_municipio",
                        column: x => x.municipio_id,
                        principalTable: "municipio",
                        principalColumn: "municipio_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sucursal_pais",
                        column: x => x.pais_id,
                        principalTable: "pais",
                        principalColumn: "pais_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hdarchivo",
                columns: table => new
                {
                    hd_archivo_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    hd_doc_id = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(maxLength: 150, nullable: false),
                    nombrefile = table.Column<string>(maxLength: 250, nullable: false),
                    f_crea = table.Column<DateTime>(nullable: false),
                    usuario_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hdarchivo", x => x.hd_archivo_id);
                    table.ForeignKey(
                        name: "fk_hdarchivo_hddoc",
                        column: x => x.hd_doc_id,
                        principalTable: "hddoc",
                        principalColumn: "hd_doc_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hdarchivo_usuario",
                        column: x => x.usuario_id,
                        principalTable: "usuario",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hdseguimiento",
                columns: table => new
                {
                    hd_seguimiento_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    observaciones = table.Column<string>(type: "text", nullable: false),
                    f_crea = table.Column<DateTime>(nullable: false),
                    hd_doc_id = table.Column<int>(nullable: false),
                    usuario_id = table.Column<int>(nullable: false),
                    status_175_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hdseguimiento", x => x.hd_seguimiento_id);
                    table.ForeignKey(
                        name: "fk_hdseguimiento_hddoc",
                        column: x => x.hd_doc_id,
                        principalTable: "hddoc",
                        principalColumn: "hd_doc_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hdseguimiento_dd_status175",
                        column: x => x.status_175_id,
                        principalTable: "dominio_det",
                        principalColumn: "dominio_det_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_hdseguimiento_usuario",
                        column: x => x.usuario_id,
                        principalTable: "usuario",
                        principalColumn: "usuario_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cia_ciudad_id",
                table: "cia",
                column: "ciudad_id");

            migrationBuilder.CreateIndex(
                name: "IX_cia_estado_id",
                table: "cia",
                column: "estado_id");

            migrationBuilder.CreateIndex(
                name: "IX_cia_grupo_cia_id",
                table: "cia",
                column: "grupo_cia_id");

            migrationBuilder.CreateIndex(
                name: "IX_cia_marca_87_id",
                table: "cia",
                column: "marca_87_id");

            migrationBuilder.CreateIndex(
                name: "IX_cia_nombre",
                table: "cia",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cia_pais_id",
                table: "cia",
                column: "pais_id");

            migrationBuilder.CreateIndex(
                name: "IX_cia_rif",
                table: "cia",
                column: "rif",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cia_soporte_id",
                table: "cia",
                column: "soporte_id");

            migrationBuilder.CreateIndex(
                name: "IX_cia_tipo_166_id",
                table: "cia",
                column: "tipo_166_id");

            migrationBuilder.CreateIndex(
                name: "IX_ciudad_estado_id_nombre",
                table: "ciudad",
                columns: new[] { "estado_id", "nombre" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dominio_descripcion",
                table: "dominio",
                column: "descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dominio_det_pais_id",
                table: "dominio_det",
                column: "pais_id");

            migrationBuilder.CreateIndex(
                name: "IX_dominio_det_dominio_id_pais_id_codigo",
                table: "dominio_det",
                columns: new[] { "dominio_id", "pais_id", "codigo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dominio_det_dominio_id_pais_id_descripcion",
                table: "dominio_det",
                columns: new[] { "dominio_id", "pais_id", "descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_estado_pais_id_nombre",
                table: "estado",
                columns: new[] { "pais_id", "nombre" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_grupo_cia_nombre",
                table: "grupo_cia",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_hdarchivo_hd_doc_id",
                table: "hdarchivo",
                column: "hd_doc_id");

            migrationBuilder.CreateIndex(
                name: "IX_hdarchivo_usuario_id",
                table: "hdarchivo",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_aplicacion_178_id",
                table: "hddoc",
                column: "aplicacion_178_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_cia_id",
                table: "hddoc",
                column: "cia_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_consultor_id",
                table: "hddoc",
                column: "consultor_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_modulo_214_id",
                table: "hddoc",
                column: "modulo_214_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_motivo_298_id",
                table: "hddoc",
                column: "motivo_298_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_pais_id",
                table: "hddoc",
                column: "pais_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_programador_id",
                table: "hddoc",
                column: "programador_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_status_175_id",
                table: "hddoc",
                column: "status_175_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_tipo_172_id",
                table: "hddoc",
                column: "tipo_172_id");

            migrationBuilder.CreateIndex(
                name: "IX_hddoc_urgencia_170_id",
                table: "hddoc",
                column: "urgencia_170_id");

            migrationBuilder.CreateIndex(
                name: "IX_hdseguimiento_hd_doc_id",
                table: "hdseguimiento",
                column: "hd_doc_id");

            migrationBuilder.CreateIndex(
                name: "IX_hdseguimiento_status_175_id",
                table: "hdseguimiento",
                column: "status_175_id");

            migrationBuilder.CreateIndex(
                name: "IX_hdseguimiento_usuario_id",
                table: "hdseguimiento",
                column: "usuario_id");

            migrationBuilder.CreateIndex(
                name: "IX_municipio_estado_id_nombre",
                table: "municipio",
                columns: new[] { "estado_id", "nombre" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pais_nombre",
                table: "pais",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_persona_cedula",
                table: "persona",
                column: "cedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_persona_sexo_6_id",
                table: "persona",
                column: "sexo_6_id");

            migrationBuilder.CreateIndex(
                name: "IX_rol_nombre",
                table: "rol",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_soporte_nombre",
                table: "soporte",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sucursal_ciudad_id",
                table: "sucursal",
                column: "ciudad_id");

            migrationBuilder.CreateIndex(
                name: "IX_sucursal_estado_id",
                table: "sucursal",
                column: "estado_id");

            migrationBuilder.CreateIndex(
                name: "IX_sucursal_municipio_id",
                table: "sucursal",
                column: "municipio_id");

            migrationBuilder.CreateIndex(
                name: "IX_sucursal_pais_id",
                table: "sucursal",
                column: "pais_id");

            migrationBuilder.CreateIndex(
                name: "IX_sucursal_cia_id_nombre",
                table: "sucursal",
                columns: new[] { "cia_id", "nombre" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuario_email",
                table: "usuario",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuario_pais_id",
                table: "usuario",
                column: "pais_id");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_rol_id",
                table: "usuario",
                column: "rol_id");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_soporte_id",
                table: "usuario",
                column: "soporte_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "consecutivo_hd");

            migrationBuilder.DropTable(
                name: "hdarchivo");

            migrationBuilder.DropTable(
                name: "hdseguimiento");

            migrationBuilder.DropTable(
                name: "sucursal");

            migrationBuilder.DropTable(
                name: "hddoc");

            migrationBuilder.DropTable(
                name: "municipio");

            migrationBuilder.DropTable(
                name: "cia");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "ciudad");

            migrationBuilder.DropTable(
                name: "grupo_cia");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "soporte");

            migrationBuilder.DropTable(
                name: "dominio_det");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "dominio");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
