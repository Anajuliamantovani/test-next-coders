using Contexts;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Adicione a política de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

//configuração do Dbcontext para usar Mysql
builder.Services.AddDbContext<GerenciadorTarefasDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 39))));

//Vai controlar o fluxo de entrada e saida do sistema
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{   
    //cabeçalho do projeto
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Gerenciador de Tarefas", Version = "v1" });

    //para renomear esquemas de tipos
    c.CustomSchemaIds(type => type.FullName);
});

//Construção da api
var app = builder.Build();

//mapeamento das rotas da api
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gerenciador de Tarefas V1");
});

app.Run();
