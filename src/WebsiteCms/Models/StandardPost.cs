using Piranha.AttributeBuilder;
using Piranha.Models;

namespace WebsiteCms.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}