namespace RRHH.API.Dtos.Common
{
    public class PageDto<T>
    {
        public int currentPage { get; set; }

        public bool hasNextPage { get; set; }

        public bool hasPreviousPage { get; set; }

        public int PageSize { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; set; }

        public T? Items { get; set; }
    }
}