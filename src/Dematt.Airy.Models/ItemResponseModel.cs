namespace Dematt.Airy.Models
{
    /// <summary>
    /// Response model for a single entity.
    /// </summary>
    /// <typeparam name="TEntityModel">The type of data the response will contain.</typeparam>
    public class ItemResponseModel<TEntityModel> : BaseItemResponseModel<TEntityModel, ItemMetaModel>
        where TEntityModel : IEntityModel
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ItemResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <remarks>
        /// Parameter less constructor to enable serialization.
        /// </remarks>
        public ItemResponseModel()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ItemResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <param name="data">The response data.</param>
        public ItemResponseModel(TEntityModel data)
            : base(data)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ItemResponseModel{TEntityModel}"/> class.
        /// </summary>
        /// <param name="data">The response data.</param>
        /// <param name="metaData">The response metadata.</param>
        public ItemResponseModel(TEntityModel data, ItemMetaModel metaData)
            : base(data, metaData)
        {
        }
    }
}
