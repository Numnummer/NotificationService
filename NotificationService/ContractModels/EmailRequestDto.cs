namespace NotificationService.ContractModels
{
    public record EmailRequestDto(string from,
        string to,
        string subject,
        string body);

}
