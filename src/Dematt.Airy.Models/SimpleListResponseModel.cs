using System.Collections.Generic;

namespace Dematt.Airy.Models
{
    /// <summary>
    /// Response model for simple lists.
    /// </summary>
    /// <typeparam name="TEntityModel">The type of data the response will contain.</typeparam>
    public class SimpleListResponseModel<TEntityModel> : BaseListResponseModel<TEntityModel, SimpleListMetaModel>
        where TEntityModel : IEntityModel
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="SimpleListResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <remarks>
        /// Parameter less constructor to enable serialization.
        /// </remarks>
        public SimpleListResponseModel()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="SimpleListResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <param name="data">The response data.</param>
        public SimpleListResponseModel(IEnumerable<TEntityModel> data)
            : base(data)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="SimpleListResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <param name="data">The response data.</param>
        /// <param name="metaData">The response metadata.</param>
        public SimpleListResponseModel(IEnumerable<TEntityModel> data, SimpleListMetaModel metaData)
            : base(data, metaData)
        {
        }
    }
}
