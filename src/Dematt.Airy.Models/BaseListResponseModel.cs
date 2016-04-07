using System.Collections.Generic;

namespace Dematt.Airy.Models
{
    /// <summary>
    /// Base model for returning responses that contain multiple model entities of the same type.
    /// </summary>
    /// <typeparam name="TEntityModel">The type of data the response will contain.</typeparam>
    /// <typeparam name="TMetaModel">The type of metadata the response will contain.</typeparam>
    public abstract class BaseListResponseModel<TEntityModel, TMetaModel>
        where TEntityModel : IEntityModel
        where TMetaModel : IMetaModel
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="BaseListResponseModel{TEntityModel,TMetaModel}"/> class.
        /// </summary>
        /// <remarks>
        /// Parameter less constructor to enable serialization.
        /// </remarks>
        protected BaseListResponseModel()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="BaseListResponseModel{TEntityModel,TMetaModel}"/> class.
        /// </summary>
        /// <param name="data">The response data.</param>
        protected BaseListResponseModel(IEnumerable<TEntityModel> data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="BaseListResponseModel{TEntityModel,TMetaModel}"/> class.
        /// </summary>
        /// <param name="data">The response data.</param>
        /// <param name="metadata">The response metadata.</param>
        protected BaseListResponseModel(IEnumerable<TEntityModel> data, TMetaModel metadata)
        {
            this.Data = data;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets the data for the response.
        /// </summary>
        public IEnumerable<TEntityModel> Data { get; set; }

        /// <summary>
        /// Gets or sets the meta data for the response.
        /// </summary>
        public TMetaModel Metadata { get; set; }
    }
}