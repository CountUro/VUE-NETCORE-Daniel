using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class deleterestrictcascadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cia_ciudad",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_estado",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_grupoCia",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_dd_marca87",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_pais",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_soporte",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_dd_166",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_ciudad_estado",
                table: "ciudad");

            migrationBuilder.DropForeignKey(
                name: "fk_dominiodet_dominio",
                table: "dominio_det");

            migrationBuilder.DropForeignKey(
                name: "fk_dominiodet_pais",
                table: "dominio_det");

            migrationBuilder.DropForeignKey(
                name: "fk_estado_pais",
                table: "estado");

            migrationBuilder.DropForeignKey(
                name: "fk_hdarchivo_hddoc",
                table: "hdarchivo");

            migrationBuilder.DropForeignKey(
                name: "fk_hdarchivo_usuario",
                table: "hdarchivo");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_aplicacion178",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_cia",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_consultor",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_modulo214",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_motivo298",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_pais",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_persona",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_programador",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_status175",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_tipo172",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_consultor",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hdseguimiento_hddoc",
                table: "hdseguimiento");

            migrationBuilder.DropForeignKey(
                name: "fk_hdseguimiento_dd_status175",
                table: "hdseguimiento");

            migrationBuilder.DropForeignKey(
                name: "fk_hdseguimiento_usuario",
                table: "hdseguimiento");

            migrationBuilder.DropForeignKey(
                name: "fk_municipio_estado",
                table: "municipio");

            migrationBuilder.DropForeignKey(
                name: "fk_persona_dd_sexo6",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "fk_sucursal_cia",
                table: "sucursal");

            migrationBuilder.DropForeignKey(
                name: "fk_sucursal_ciudad",
                table: "sucursal");

            migrationBuilder.DropForeignKey(
                name: "fk_sucursal_estado",
                table: "sucursal");

            migrationBuilder.DropForeignKey(
                name: "fk_sucursal_pais",
                table: "sucursal");

            migrationBuilder.DropForeignKey(
                name: "fk_usuario_pais",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "fk_usuario_rol",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "fk_usuario_soporte",
                table: "usuario");

            migrationBuilder.AddForeignKey(
                name: "fk_cia_ciudad",
                table: "cia",
                column: "ciudad_id",
                principalTable: "ciudad",
                principalColumn: "ciudad_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_estado",
                table: "cia",
                column: "estado_id",
                principalTable: "estado",
                principalColumn: "estado_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_grupoCia",
                table: "cia",
                column: "grupo_cia_id",
                principalTable: "grupo_cia",
                principalColumn: "grupo_cia_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_dd_marca87",
                table: "cia",
                column: "marca_87_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_pais",
                table: "cia",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_soporte",
                table: "cia",
                column: "soporte_id",
                principalTable: "soporte",
                principalColumn: "soporte_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_dd_166",
                table: "cia",
                column: "tipo_166_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_ciudad_estado",
                table: "ciudad",
                column: "estado_id",
                principalTable: "estado",
                principalColumn: "estado_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_dominiodet_dominio",
                table: "dominio_det",
                column: "dominio_id",
                principalTable: "dominio",
                principalColumn: "dominio_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_dominiodet_pais",
                table: "dominio_det",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_estado_pais",
                table: "estado",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hdarchivo_hddoc",
                table: "hdarchivo",
                column: "hd_doc_id",
                principalTable: "hddoc",
                principalColumn: "hd_doc_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hdarchivo_usuario",
                table: "hdarchivo",
                column: "usuario_id",
                principalTable: "usuario",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_aplicacion178",
                table: "hddoc",
                column: "aplicacion_178_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_cia",
                table: "hddoc",
                column: "cia_id",
                principalTable: "cia",
                principalColumn: "cia_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_consultor",
                table: "hddoc",
                column: "consultor_id",
                principalTable: "usuario",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_modulo214",
                table: "hddoc",
                column: "modulo_214_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_motivo298",
                table: "hddoc",
                column: "motivo_298_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_pais",
                table: "hddoc",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_persona",
                table: "hddoc",
                column: "programador_id",
                principalTable: "persona",
                principalColumn: "persona_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_programador",
                table: "hddoc",
                column: "programador_id",
                principalTable: "usuario",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_status175",
                table: "hddoc",
                column: "status_175_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_tipo172",
                table: "hddoc",
                column: "tipo_172_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_consultor",
                table: "hddoc",
                column: "urgencia_170_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hdseguimiento_hddoc",
                table: "hdseguimiento",
                column: "hd_doc_id",
                principalTable: "hddoc",
                principalColumn: "hd_doc_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hdseguimiento_dd_status175",
                table: "hdseguimiento",
                column: "status_175_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_hdseguimiento_usuario",
                table: "hdseguimiento",
                column: "usuario_id",
                principalTable: "usuario",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_municipio_estado",
                table: "municipio",
                column: "estado_id",
                principalTable: "estado",
                principalColumn: "estado_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_persona_dd_sexo6",
                table: "persona",
                column: "sexo_6_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_sucursal_cia",
                table: "sucursal",
                column: "cia_id",
                principalTable: "cia",
                principalColumn: "cia_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_sucursal_ciudad",
                table: "sucursal",
                column: "ciudad_id",
                principalTable: "ciudad",
                principalColumn: "ciudad_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_sucursal_estado",
                table: "sucursal",
                column: "estado_id",
                principalTable: "estado",
                principalColumn: "estado_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_sucursal_pais",
                table: "sucursal",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_usuario_pais",
                table: "usuario",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_usuario_rol",
                table: "usuario",
                column: "rol_id",
                principalTable: "rol",
                principalColumn: "rol_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_usuario_soporte",
                table: "usuario",
                column: "soporte_id",
                principalTable: "soporte",
                principalColumn: "soporte_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cia_ciudad",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_estado",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_grupoCia",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_dd_marca87",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_pais",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_soporte",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_cia_dd_166",
                table: "cia");

            migrationBuilder.DropForeignKey(
                name: "fk_ciudad_estado",
                table: "ciudad");

            migrationBuilder.DropForeignKey(
                name: "fk_dominiodet_dominio",
                table: "dominio_det");

            migrationBuilder.DropForeignKey(
                name: "fk_dominiodet_pais",
                table: "dominio_det");

            migrationBuilder.DropForeignKey(
                name: "fk_estado_pais",
                table: "estado");

            migrationBuilder.DropForeignKey(
                name: "fk_hdarchivo_hddoc",
                table: "hdarchivo");

            migrationBuilder.DropForeignKey(
                name: "fk_hdarchivo_usuario",
                table: "hdarchivo");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_aplicacion178",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_cia",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_consultor",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_modulo214",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_motivo298",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_pais",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_persona",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_programador",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_status175",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_tipo172",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hddoc_dd_consultor",
                table: "hddoc");

            migrationBuilder.DropForeignKey(
                name: "fk_hdseguimiento_hddoc",
                table: "hdseguimiento");

            migrationBuilder.DropForeignKey(
                name: "fk_hdseguimiento_dd_status175",
                table: "hdseguimiento");

            migrationBuilder.DropForeignKey(
                name: "fk_hdseguimiento_usuario",
                table: "hdseguimiento");

            migrationBuilder.DropForeignKey(
                name: "fk_municipio_estado",
                table: "municipio");

            migrationBuilder.DropForeignKey(
                name: "fk_persona_dd_sexo6",
                table: "persona");

            migrationBuilder.DropForeignKey(
                name: "fk_sucursal_cia",
                table: "sucursal");

            migrationBuilder.DropForeignKey(
                name: "fk_sucursal_ciudad",
                table: "sucursal");

            migrationBuilder.DropForeignKey(
                name: "fk_sucursal_estado",
                table: "sucursal");

            migrationBuilder.DropForeignKey(
                name: "fk_sucursal_pais",
                table: "sucursal");

            migrationBuilder.DropForeignKey(
                name: "fk_usuario_pais",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "fk_usuario_rol",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "fk_usuario_soporte",
                table: "usuario");

            migrationBuilder.AddForeignKey(
                name: "fk_cia_ciudad",
                table: "cia",
                column: "ciudad_id",
                principalTable: "ciudad",
                principalColumn: "ciudad_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_estado",
                table: "cia",
                column: "estado_id",
                principalTable: "estado",
                principalColumn: "estado_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_grupoCia",
                table: "cia",
                column: "grupo_cia_id",
                principalTable: "grupo_cia",
                principalColumn: "grupo_cia_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_dd_marca87",
                table: "cia",
                column: "marca_87_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_pais",
                table: "cia",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_soporte",
                table: "cia",
                column: "soporte_id",
                principalTable: "soporte",
                principalColumn: "soporte_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cia_dd_166",
                table: "cia",
                column: "tipo_166_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_ciudad_estado",
                table: "ciudad",
                column: "estado_id",
                principalTable: "estado",
                principalColumn: "estado_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_dominiodet_dominio",
                table: "dominio_det",
                column: "dominio_id",
                principalTable: "dominio",
                principalColumn: "dominio_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_dominiodet_pais",
                table: "dominio_det",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_estado_pais",
                table: "estado",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hdarchivo_hddoc",
                table: "hdarchivo",
                column: "hd_doc_id",
                principalTable: "hddoc",
                principalColumn: "hd_doc_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hdarchivo_usuario",
                table: "hdarchivo",
                column: "usuario_id",
                principalTable: "usuario",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_aplicacion178",
                table: "hddoc",
                column: "aplicacion_178_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_cia",
                table: "hddoc",
                column: "cia_id",
                principalTable: "cia",
                principalColumn: "cia_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_consultor",
                table: "hddoc",
                column: "consultor_id",
                principalTable: "usuario",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_modulo214",
                table: "hddoc",
                column: "modulo_214_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_motivo298",
                table: "hddoc",
                column: "motivo_298_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_pais",
                table: "hddoc",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_persona",
                table: "hddoc",
                column: "programador_id",
                principalTable: "persona",
                principalColumn: "persona_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_programador",
                table: "hddoc",
                column: "programador_id",
                principalTable: "usuario",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_status175",
                table: "hddoc",
                column: "status_175_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_tipo172",
                table: "hddoc",
                column: "tipo_172_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hddoc_dd_consultor",
                table: "hddoc",
                column: "urgencia_170_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hdseguimiento_hddoc",
                table: "hdseguimiento",
                column: "hd_doc_id",
                principalTable: "hddoc",
                principalColumn: "hd_doc_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hdseguimiento_dd_status175",
                table: "hdseguimiento",
                column: "status_175_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_hdseguimiento_usuario",
                table: "hdseguimiento",
                column: "usuario_id",
                principalTable: "usuario",
                principalColumn: "usuario_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_municipio_estado",
                table: "municipio",
                column: "estado_id",
                principalTable: "estado",
                principalColumn: "estado_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_persona_dd_sexo6",
                table: "persona",
                column: "sexo_6_id",
                principalTable: "dominio_det",
                principalColumn: "dominio_det_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_sucursal_cia",
                table: "sucursal",
                column: "cia_id",
                principalTable: "cia",
                principalColumn: "cia_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_sucursal_ciudad",
                table: "sucursal",
                column: "ciudad_id",
                principalTable: "ciudad",
                principalColumn: "ciudad_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_sucursal_estado",
                table: "sucursal",
                column: "estado_id",
                principalTable: "estado",
                principalColumn: "estado_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_sucursal_pais",
                table: "sucursal",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_usuario_pais",
                table: "usuario",
                column: "pais_id",
                principalTable: "pais",
                principalColumn: "pais_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_usuario_rol",
                table: "usuario",
                column: "rol_id",
                principalTable: "rol",
                principalColumn: "rol_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_usuario_soporte",
                table: "usuario",
                column: "soporte_id",
                principalTable: "soporte",
                principalColumn: "soporte_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
