
namespace RRHH.API.Services.Employees.Constants
{
    /// <summary>
    /// Contiene los códigos de estado HTTP utilizados en las respuestas del API.
    /// </summary>
    public static class HttpStatusCodeConstant
    {
        #region 2xx - Códigos de éxito

        /// <summary>
        /// 200 OK: La solicitud ha tenido éxito.
        /// </summary>
        public const int OK = 200;

        /// <summary>
        /// 201 Created: La solicitud se ha completado y se ha creado un nuevo recurso.
        /// </summary>
        public const int Created = 201;

        /// <summary>
        /// 202 Accepted: La solicitud ha sido aceptada para su procesamiento,
        /// pero todavía no ha sido completada.
        /// </summary>
        public const int Accepted = 202;

        /// <summary>
        /// 204 No Content: La solicitud se ha procesado correctamente,
        /// pero no hay contenido que devolver.
        /// </summary>
        public const int NoContent = 204;

        #endregion

        #region 3xx - Códigos de redirección

        /// <summary>
        /// 301 Moved Permanently: El recurso solicitado se ha trasladado
        /// permanentemente a otra ubicación.
        /// </summary>
        public const int MovedPermanently = 301;

        /// <summary>
        /// 302 Found: El recurso solicitado se encuentra temporalmente
        /// en otra ubicación.
        /// </summary>
        public const int Found = 302;

        /// <summary>
        /// 304 Not Modified: El recurso no ha sido modificado desde
        /// la última solicitud.
        /// </summary>
        public const int NotModified = 304;

        #endregion

        #region 4xx - Errores del cliente

        /// <summary>
        /// 400 Bad Request: La solicitud contiene datos incorrectos
        /// o no cumple con el formato esperado.
        /// </summary>
        public const int BadRequest = 400;

        /// <summary>
        /// 401 Unauthorized: La solicitud requiere autenticación
        /// o las credenciales proporcionadas no son válidas.
        /// </summary>
        public const int Unauthorized = 401;

        /// <summary>
        /// 403 Forbidden: El servidor ha entendido la solicitud,
        /// pero el usuario no tiene permisos para acceder al recurso.
        /// </summary>
        public const int Forbidden = 403;

        /// <summary>
        /// 404 Not Found: El recurso solicitado no existe
        /// o no se encuentra disponible.
        /// </summary>
        public const int NotFound = 404;

        /// <summary>
        /// 405 Method Not Allowed: El método HTTP utilizado
        /// no está permitido para el recurso solicitado.
        /// </summary>
        public const int MethodNotAllowed = 405;

        /// <summary>
        /// 406 Not Acceptable: El servidor no puede generar
        /// una respuesta que cumpla con los formatos aceptados por el cliente.
        /// </summary>
        public const int NotAcceptable = 406;

        /// <summary>
        /// 408 Request Timeout: El servidor ha agotado el tiempo
        /// de espera para recibir la solicitud.
        /// </summary>
        public const int RequestTimeout = 408;

        /// <summary>
        /// 409 Conflict: La solicitud entra en conflicto con
        /// el estado actual del recurso.
        /// </summary>
        public const int Conflict = 409;

        /// <summary>
        /// 410 Gone: El recurso solicitado ya no está disponible
        /// y no volverá a estarlo.
        /// </summary>
        public const int Gone = 410;

        /// <summary>
        /// 412 Precondition Failed: Una o varias condiciones
        /// especificadas en la solicitud no se han cumplido.
        /// </summary>
        public const int PreconditionFailed = 412;

        /// <summary>
        /// 413 Content Too Large: El contenido de la solicitud
        /// supera el tamaño permitido por el servidor.
        /// </summary>
        public const int ContentTooLarge = 413;

        /// <summary>
        /// 415 Unsupported Media Type: El formato del contenido
        /// enviado no es compatible con el servidor.
        /// </summary>
        public const int UnsupportedMediaType = 415;

        /// <summary>
        /// 422 Unprocessable Content: La solicitud tiene un formato
        /// válido, pero contiene datos que no pueden procesarse.
        /// </summary>
        public const int UnprocessableContent = 422;

        /// <summary>
        /// 429 Too Many Requests: El cliente ha realizado
        /// demasiadas solicitudes en un período determinado.
        /// </summary>
        public const int TooManyRequests = 429;

        #endregion

        #region 5xx - Errores del servidor

        /// <summary>
        /// 500 Internal Server Error: Se ha producido un error interno
        /// inesperado en el servidor.
        /// </summary>
        public const int InternalServerError = 500;

        /// <summary>
        /// 501 Not Implemented: El servidor no admite
        /// la funcionalidad necesaria para procesar la solicitud.
        /// </summary>
        public const int NotImplemented = 501;

        /// <summary>
        /// 502 Bad Gateway: El servidor, actuando como puerta de enlace
        /// o proxy, ha recibido una respuesta no válida de otro servidor.
        /// </summary>
        public const int BadGateway = 502;

        /// <summary>
        /// 503 Service Unavailable: El servidor no está disponible
        /// temporalmente, posiblemente por mantenimiento o sobrecarga.
        /// </summary>
        public const int ServiceUnavailable = 503;

        /// <summary>
        /// 504 Gateway Timeout: El servidor, actuando como puerta de enlace
        /// o proxy, no ha recibido una respuesta a tiempo de otro servidor.
        /// </summary>
        public const int GatewayTimeout = 504;

        #endregion
    }
}
