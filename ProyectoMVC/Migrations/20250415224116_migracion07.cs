using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoMVC.Migrations
{
    public partial class migracion07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.IdEspecialidad);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Residencia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.IdPaciente);
                });

            migrationBuilder.CreateTable(
                name: "Puesto",
                columns: table => new
                {
                    IdPuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puesto", x => x.IdPuesto);
                });

            migrationBuilder.CreateTable(
                name: "Tratamiento",
                columns: table => new
                {
                    IdTratamiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoTr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Frecuencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionTr = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamiento", x => x.IdTratamiento);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Pago",
                columns: table => new
                {
                    IdPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Metodo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pago", x => x.IdPago);
                    table.ForeignKey(
                        name: "FK_Pago_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Residencia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PuestoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionario_Puesto_PuestoId",
                        column: x => x.PuestoId,
                        principalTable: "Puesto",
                        principalColumn: "IdPuesto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bitacora",
                columns: table => new
                {
                    IdBitacora = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Movimiento = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitacora", x => x.IdBitacora);
                    table.ForeignKey(
                        name: "FK_Bitacora_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Especialista",
                columns: table => new
                {
                    IdEspecialista = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialista", x => x.IdEspecialista);
                    table.ForeignKey(
                        name: "FK_Especialista_Especialidad_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidad",
                        principalColumn: "IdEspecialidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Especialista_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    IdCita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    EspecialistaId = table.Column<int>(type: "int", nullable: false),
                    DiaCita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraCita = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.IdCita);
                    table.ForeignKey(
                        name: "FK_Cita_Especialista_EspecialistaId",
                        column: x => x.EspecialistaId,
                        principalTable: "Especialista",
                        principalColumn: "IdEspecialista",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cita_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Horario",
                columns: table => new
                {
                    IdHorario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraEntrada = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraSalida = table.Column<TimeSpan>(type: "time", nullable: false),
                    EspecialistaId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioIdFuncionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.IdHorario);
                    table.ForeignKey(
                        name: "FK_Horario_Especialista_EspecialistaId",
                        column: x => x.EspecialistaId,
                        principalTable: "Especialista",
                        principalColumn: "IdEspecialista",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Horario_Funcionario_FuncionarioIdFuncionario",
                        column: x => x.FuncionarioIdFuncionario,
                        principalTable: "Funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnostico",
                columns: table => new
                {
                    IdDiagnostico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionDi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CitaIdCita = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostico", x => x.IdDiagnostico);
                    table.ForeignKey(
                        name: "FK_Diagnostico_Cita_CitaIdCita",
                        column: x => x.CitaIdCita,
                        principalTable: "Cita",
                        principalColumn: "IdCita",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistorialClinico",
                columns: table => new
                {
                    IdHistorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TratamientoId = table.Column<int>(type: "int", nullable: false),
                    DiagnosticoId = table.Column<int>(type: "int", nullable: false),
                    CitaId = table.Column<int>(type: "int", nullable: false),
                    PacienteIdPaciente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialClinico", x => x.IdHistorial);
                    table.ForeignKey(
                        name: "FK_HistorialClinico_Cita_CitaId",
                        column: x => x.CitaId,
                        principalTable: "Cita",
                        principalColumn: "IdCita",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorialClinico_Diagnostico_DiagnosticoId",
                        column: x => x.DiagnosticoId,
                        principalTable: "Diagnostico",
                        principalColumn: "IdDiagnostico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorialClinico_Paciente_PacienteIdPaciente",
                        column: x => x.PacienteIdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistorialClinico_Tratamiento_TratamientoId",
                        column: x => x.TratamientoId,
                        principalTable: "Tratamiento",
                        principalColumn: "IdTratamiento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bitacora_UsuarioId",
                table: "Bitacora",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_EspecialistaId",
                table: "Cita",
                column: "EspecialistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_PacienteId",
                table: "Cita",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostico_CitaIdCita",
                table: "Diagnostico",
                column: "CitaIdCita");

            migrationBuilder.CreateIndex(
                name: "IX_Especialista_EspecialidadId",
                table: "Especialista",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Especialista_FuncionarioId",
                table: "Especialista",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_PuestoId",
                table: "Funcionario",
                column: "PuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialClinico_CitaId",
                table: "HistorialClinico",
                column: "CitaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialClinico_DiagnosticoId",
                table: "HistorialClinico",
                column: "DiagnosticoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialClinico_PacienteIdPaciente",
                table: "HistorialClinico",
                column: "PacienteIdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialClinico_TratamientoId",
                table: "HistorialClinico",
                column: "TratamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_EspecialistaId",
                table: "Horario",
                column: "EspecialistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_FuncionarioIdFuncionario",
                table: "Horario",
                column: "FuncionarioIdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_Pago_PacienteId",
                table: "Pago",
                column: "PacienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bitacora");

            migrationBuilder.DropTable(
                name: "HistorialClinico");

            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropTable(
                name: "Pago");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Diagnostico");

            migrationBuilder.DropTable(
                name: "Tratamiento");

            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Especialista");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Puesto");
        }
    }
}
