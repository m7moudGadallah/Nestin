namespace Nestin.Core.Entities
{
    /// <summary>
    /// Base Entity for Entities in our system 
    /// </summary>
    /// <typeparam name="T">Represents type of entity Id (`string` or `int`)</typeparam>
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
