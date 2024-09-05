namespace Payment.Services;

public interface IPaymentService
{
    void Charge();
    void Refund();
}
