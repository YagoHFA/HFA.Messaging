namespace HFA.Messaging.Contracts
{
    public sealed record EmailMessage(
        Guid MessageId,
        EmailType Type,
        string To,
        string? Subject,
        IReadOnlyDictionary<string, string>? TemplateData,
        DateTime CreatedAtUtc
    );
}