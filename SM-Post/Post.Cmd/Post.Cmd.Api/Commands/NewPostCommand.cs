
using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class NewPostCommand: BaseCommand
    {
        public string Author { get; set; } = default!;
        public string Message { get; set; } = default!;
    }
}