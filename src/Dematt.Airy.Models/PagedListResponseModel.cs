using System.Collections.Generic;
using PagedList;

namespace Dematt.Airy.Models
{
    /// <summary>
    /// Response model for paged lists.
    /// </summary>
    /// <typeparam name="TEntityModel">The type of data the response will contain.</typeparam>
    public class PagedListResponseModel<TEntityModel> : BaseListResponseModel<TEntityModel, PagedListMetaModel>
        where TEntityModel : IEntityModel
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="PagedListResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <remarks>
        /// Parameter less constructor to enable serialization.
        /// </remarks>
        public PagedListResponseModel()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="PagedListResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <param name="data">The response data.</param>
        public PagedListResponseModel(IEnumerable<TEntityModel> data)
            : base(data)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="PagedListResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <param name="data">The response data.</param>
        /// <param name="metadata">The response metadata.</param>
        public PagedListResponseModel(IEnumerable<TEntityModel> data, PagedListMetaModel metadata)
            : base(data, metadata)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="PagedListResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <param name="data">The response data.</param>
        /// <param name="metadata">The response metadata.</param>
        public PagedListResponseModel(IEnumerable<TEntityModel> data, IPagedList metadata)
            : base(data)
        {
            this.Metadata = new PagedListMetaModel(metadata);
        }
    }
}
