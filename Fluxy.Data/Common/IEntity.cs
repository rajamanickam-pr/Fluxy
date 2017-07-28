namespace Fluxy.Data.Model.Common
{
    public interface IEntity<T> 
   {
       T Id { get; set; }
   }
}
