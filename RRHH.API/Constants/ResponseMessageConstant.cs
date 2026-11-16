namespace RRHH.API.Services.Employees.Constants
{
    public static class ResponseMessageConstant
    {
        public const string created = "el registro ha sido creado correctamente";

        public const string found = "el registro ha sido actualizado correctamente";

        public const string notFound = "el registro no ha sido encontrado";

        public static string? NotFound { get; internal set; }
        public static string Updated { get; internal set; }
    }
}