# Task Progress Overview
In this Lab work, 11 principles of proper software engineering were applied:

## DRY Principle
To lesser the amount of code writing, [DateSpan's](https://github.com/simon-arch/SoftwareEngineering/blob/main/lab-1/DocManagement/Documents/Data/DateSpan.cs) [IsExpired](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Data/DateSpan.cs#L12) method is created. Instead of implementing this method in each concrete document added, it is
[included](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs#L8) while setting up issue and expiration dates, keeping validation separated in one place.

Because [QR Code generation](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs#L29) is the same for each document, it is moved to the abstract class [Document](https://github.com/simon-arch/SoftwareEngineering/blob/main/lab-1/DocManagement/Documents/Document.cs) to avoid repeated implementation. The same is applied when [showing document overview](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs#L12).

## KISS Principle
To keep the code simple, models are defined as close to the task as possible.
Methods and classes are named to properly convey what they're doing:
* [Document](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs) manages documents and their respective data.
* [Container Display](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/Display/ContainerDisplay.cs) defines document display strategies when viewed from container.
* [Document Container Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs) contains and serves documents.
* [Document Validator Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/DocumentValidatorService.cs) checks and validates document expiration. 

The same goes for properties and arguments, for example:
* [IssuedBy](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs#L7) contains authority name which issued said document.
* [FullName](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs#L6) contains owner's full name.
* [Documents](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L4) contains all of the container documents.

Simple structures are used like [lists](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L4) and [primitives](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs#L5) to avoid overcomplication.

## SOLID
### Single Responsibility Principle
Classes and methods have their own responsibilites and operate on the same level of abstraction:

[Document](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs) is a base class which is only responsible for working on the document abstraction level:
* [ShowOverview](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs#L12), [DisplayFull](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Concrete/DriversLicense.cs#L32) and [DisplayHidden](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Concrete/Passport.cs#L50) each display their respective info only.
* [Generate QR Code](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs#L29) is responsible for only creating hypothetical QR Codes.

[Document Container Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs) works only on the document container abstraction level:
* [AddDocument](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L13) is responsible for adding valid documents. 
* [Validation](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L21) is handled by a separate [Document Validator Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/DocumentValidatorService.cs).
* [FindDocumentById](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L32) searches documents by id.
* [RemoveDocument](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L41) deletes documents.
* [ChangeDocumentOrder](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L50) moves document by indices.
* [ShowDocuments](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L60) calls for the respective document [Display strategy](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L5).

[Container Display](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/Display/ContainerDisplay.cs) is used to select document output strategy.

### Open Closed Principle
There are multiple [concerete](https://github.com/simon-arch/SoftwareEngineering/tree/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Concrete) implementations of the [Document](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs) class:
* [DriversLicense](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Concrete/DriversLicense.cs)
* [MilitaryRecord](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Concrete/MilitaryRecord.cs)
* [Passport](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Concrete/Passport.cs)

Each of them uses open closed principle to reuse the base class' functionality and [add it's own](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Concrete/DriversLicense.cs#L27) without actually changing already existing code structure.

### Liskov Substitution Principle
Objects of a base class are able to be properly replaced with objects of a child class without changing the correctness of the program. 

Each child's method is implemented, which means they're replaceable ([here](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Program.cs#L55) and [here](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/Display/ContainerDisplay.cs#L18) for example) by each other without excess casting and result in the same predicted output.

### Interface Segregation Principle
Interfaces ICopiable and ISendable are present, which are created in order to not group unrelated behavior in one interface:
* [ICopiable](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/ICopiable.cs) contains [Copy Document](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/ICopiable.cs#L5) contract, which is in this case needed for passport and military record to "copy" related data. 
* [ISendable](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/ISendable.cs) contract [Send Document](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/ISendable.cs#L5) is required by the passport to "send" it's ID.

### Dependency Inversion Principle
Due to the presence of [Document Validator Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/DocumentValidatorService.cs), validation is decoupled to its own container, which makes it independent from the document container. When [instancing](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L10), any of the implementations of said validator are not acknowledged by [Document Container Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs), too.

## YAGNI Principle
Each feature is implemented in the simplest way possible before adding complexity. For example:

* [AddDocument](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L13) only checks if the document already exists and whether it's expired.
* [RemoveDocument](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L41) removes the document without complex validation except [checking for null](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L43).
* [IsExpired](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/DocumentValidatorService.cs#L3) solely checks for the proper date range.

## Composition Over Inheritance
A separate [DateSpan](https://github.com/simon-arch/SoftwareEngineering/blob/main/lab-1/DocManagement/Documents/Data/DateSpan.cs) class is present to handle working with dates and their validation checks. Document class contains an [instance](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs#L8) of this class to properly compose and reuse the desired functionality.

Same principle applies for the [Validator Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/DocumentValidatorService.cs), which has it's [logic separated](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/IDocumentValidatorService.cs#L3) and later [instanced in Document Container](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L21).

## Program to Interfaces not Implementations
Class instances used in the code implement interfaces, which makes other methods they're referenced in act independent from concrete implementations:
* [Document](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/Document.cs) implements [IDocument](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Documents/IDocument.cs) interface.
* [Document Container Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs) implements [IDocumentContainerService](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/IDocumentContainerService.cs).
* [Container Display](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/Display/ContainerDisplay.cs) implements [IContainerDisplay](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/Display/IContainerDisplay.cs).
* [Document Validator Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/DocumentValidatorService.cs) implements [IDocumentValidatorService](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/IDocumentValidatorService.cs).

This applies to the functionality inside [Document Container Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs) and [DocumentValidatorService](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/DocumentValidatorService.cs). Fields and arguments are referenced as interfaces (for example [here](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L4), [here](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L41), and [here](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Validator/DocumentValidatorService.cs#L3)) and thus doesn't need their implementations to be acknowledged, working purely on contracts.

## Fail Fast Principle
To properly handle all of the data and exclude chances of working with unpredicted input, [Document Container Service](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs) results in an exception when [null arguments](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L15), [negative indices](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L34), [existing entries](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L18) or [out-of-range indicies](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L52) provided.

It is also of high priority to [check for the document validity](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L21) and [return proper output](https://github.com/simon-arch/SoftwareEngineering/blob/0c874bdf6d8a84d89e7436be94ef278e6e250343/lab-1/DocManagement/Services/Container/DocumentContainerService.cs#L23) in case of failure.