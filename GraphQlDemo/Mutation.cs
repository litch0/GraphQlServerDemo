using GraphQlDemo.Data;

namespace GraphQlDemo
{
    public class Mutation
    {
        public Author CreateAuthor(string id, string name)
        {
            return new(id, name);
        }
    }
}