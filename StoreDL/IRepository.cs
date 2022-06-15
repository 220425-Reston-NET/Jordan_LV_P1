using StoreModel;

namespace StoreDL
{
    /// <summary>
    /// Generic repository that will accommodate for all models you will be creating in the future or existing models
    ///  
    /// </summary>
    /// <typeparam name="T">The T is a placeholder in where you will put the model in</typeparam>
    public interface IRepository<T>
    {
        //CRUD operations
        //Create, Read, Update, and Delete

        /// <summary>
        /// This will create a resource to the database
        /// </summary>
        /// <param name="p_resource">This is the resource being saved to the database</param>
        void Add(T p_resource);

        /// <summary>
        /// This will get all the specific resource from the database
        /// </summary>
        /// <returns>T is the resource being given</returns>
        List<T> GetAll();

        /// <summary>
        /// This will update an existing resource
        /// </summary>
        /// <param name="p_resource">This is the resource it is updating</param>
        void Update(T p_resource);
        Task<List<Customer>> GetAllAsync();
    }
}