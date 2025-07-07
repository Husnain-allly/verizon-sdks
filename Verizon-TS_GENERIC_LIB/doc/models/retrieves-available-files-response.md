
# Retrieves Available Files Response

*This model accepts additional fields of type unknown.*

## Structure

`RetrievesAvailableFilesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `fileName` | `string \| undefined` | Optional | ThingSpace-generated name of the file. You will use this name when listing or scheduling campaigns for the file. |
| `fileVersion` | `string \| undefined` | Optional | Version of the file. |
| `releaseNote` | `string \| undefined` | Optional | Software release note. |
| `make` | `string \| undefined` | Optional | The software-applicable device make. |
| `model` | `string \| undefined` | Optional | The software-applicable device model. |
| `localTargetPath` | `string \| undefined` | Optional | Local target path on the device. |
| `distributionType` | `string \| undefined` | Optional | Valid values |
| `devicePlatformId` | `string \| undefined` | Optional | The platform (Android, iOS, etc.,) that the software can be applied to. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "fileName": "configfile-Verizon_VZW1_hello-world.txt",
  "fileVersion": "1.0",
  "releaseNote": "Hello world initial file",
  "make": "Verizon",
  "model": "VZW1",
  "localTargetPath": "/VZWFOTA/hello-world.txt",
  "distributionType": "HTTP",
  "devicePlatformId": "IoT",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

