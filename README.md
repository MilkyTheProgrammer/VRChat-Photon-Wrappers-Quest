# Documentation
## Introduction
This documentation provides instructions and examples for using the generic wrapper in your code. The generic wrapper simplifies the process of raising events using the OpRaiseEvent method in the Photon Unity Networking (PUN) library.

## Usage of the Generic Wrapper
# Basic Usage
To use the generic wrapper, follow these steps:

Start by converting a base64 string to a byte array using `Convert.FromBase64String()`. For example, suppose you have a base64 string representing USpeak data. You can convert it as follows:

```cs
byte[] customArray = Convert.FromBase64String("Base64 String for USpeak");
```
Create a new byte array using the `CopyServerTimeAndActorId()` method provided by the generic wrapper. This method makes it easier to include the server time and actor ID in the byte array. Here's an example:

```cs
byte[] @out = PhotonExtensions.CopyServerTimeAndActorId(customArray);
```
Finally, use the OpRaise() method on the byte array to raise the desired event. Replace <event_code> with the specific event code you want to use. For example:

```cs
@out.OpRaise(<event_code>);
```
Raising Events with a Dictionary
You can also raise events using a `Dictionary<byte, object>` by using the generic wrapper. This approach simplifies the process compared to manually calling OpRaiseEvent with the wrapped code. Here's an example:

```cs
public static void Test(Vector3 vect, float rotation)
{
  Dictionary<byte, object> dict = new Dictionary<byte, object> 
  { 
  };
  
  dict.OpRaise(33);
}
```
In the above example, the OpRaise() method is used directly on the dictionary, making it simpler to raise the event. Replace <event_code> with the desired event code.

### Raising Events with an Il2CppSystem Object
The generic wrapper also allows you to raise events with an Il2CppSystem.Object. The process is similar to raising events with a dictionary. Here's an example:

```cs
Il2CppSystem.Object myObject = // Create or obtain your Il2CppSystem.Object here;
myObject.OpRaise(<event_code>);
```
Replace <event_code> with the specific event code you want to use.

## Contact Information
If you have any questions or need further assistance, you can reach out to me on Discord: "foonix.". Feel free to ask for help or clarification regarding the usage of the generic wrapper.
