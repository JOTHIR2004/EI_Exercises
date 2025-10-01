# Factory Method Pattern

## Purpose
The Factory Method Pattern defines an interface for creating an object but lets subclasses decide which class to instantiate. Ideal for creating families of related objects.

## Files

- `BankTransferPayment.cs` : Concrete product implementing payment via bank transfer.
- `CreditCardPayment.cs` : Concrete product implementing payment via credit card.
- `PayPalPayment.cs` : Concrete product implementing payment via PayPal.
- `IPayment.cs` : Product interface for payment methods.
- `PaymentFactory.cs` : Factory class to create payment objects.
- `Program.cs` : Entry point to run the Factory Method demo.
- `Factory_method.csproj` : Project file for the Factory Method pattern.

## Usage
Run `Program.cs` to see different payment methods being created and used dynamically via the factory.
