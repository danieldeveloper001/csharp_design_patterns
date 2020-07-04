# The External Services Response Example

**The External Services Response Example** makes use of the **adapter design pattern** to demonstrate how to adapt
different types from external services from a given company, namely **customer**, **employee** and **provider**. In this
example, the contents in the **services** folder simulates external services requests and responses that must be adapted
in order to be properly handled by this application as a **person**, as follows.

- **CustomerToPersonAdapter**: adapts the customer service response to a person model.
- **EmployeeToPersonAdapter**: adapts the employee service response to a person model.
- **ProviderToPersonAdapter**: adapts the provider service response to a person model.
