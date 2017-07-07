using EPiServer.Core;

namespace EpiserverDynamicForm.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
