using PagedList;

namespace Dematt.Airy.Models
{
    /// <summary>
    /// Model for holding paging information.
    /// </summary>
    public class PagedListMetaModel : IMetaModel
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="PagedListMetaModel"/> class.
        /// </summary>
        /// <remarks>
        /// Parameter less constructor to enable serialization.
        /// </remarks>
        public PagedListMetaModel()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="PagedListMetaModel"/> class.
        /// </summary>
        /// <param name="pagedList">An instance of an object that implements the <see cref="IPagedList"/> interface.</param>
        public PagedListMetaModel(IPagedList pagedList)
        {
            this.PageCount = pagedList.PageCount;
            this.PageNumber = pagedList.PageNumber;
            this.PageSize = pagedList.PageSize;
            this.TotalItemCount = pagedList.TotalItemCount;
        }

        /// <summary>
        /// Gets or sets the number of the current page.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the total number of pages.
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// Gets or sets the number of items on each page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the total number of items.
        /// </summary>
        public int TotalItemCount { get; set; }
    }
}
