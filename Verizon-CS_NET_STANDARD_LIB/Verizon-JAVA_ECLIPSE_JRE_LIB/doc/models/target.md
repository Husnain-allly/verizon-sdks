
# Target

Target resource definition.

*This model accepts additional fields of type Object.*

## Structure

`Target`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Address` | `String` | Optional | The endpoint for data streams. | String getAddress() | setAddress(String address) |
| `Addressscheme` | `String` | Optional | The transport format. | String getAddressscheme() | setAddressscheme(String addressscheme) |
| `Billingaccountid` | `String` | Optional | The billing account ID. | String getBillingaccountid() | setBillingaccountid(String billingaccountid) |
| `Createdon` | `String` | Optional | The date the resource was created. | String getCreatedon() | setCreatedon(String createdon) |
| `Externalid` | `String` | Optional | Security identification string. | String getExternalid() | setExternalid(String externalid) |
| `Id` | `String` | Optional | ThingSpace unique ID for the target that was created. | String getId() | setId(String id) |
| `Kind` | `String` | Optional | Identifies the resource kind. Targets are ts.target. | String getKind() | setKind(String kind) |
| `Lastupdated` | `String` | Optional | The date the resource was last updated. | String getLastupdated() | setLastupdated(String lastupdated) |
| `Name` | `String` | Optional | Name of the target. | String getName() | setName(String name) |
| `Region` | `String` | Optional | AWS region value. | String getRegion() | setRegion(String region) |
| `Version` | `String` | Optional | Version of the underlying schema resource. | String getVersion() | setVersion(String version) |
| `Versionid` | `String` | Optional | The version of the resource. | String getVersionid() | setVersionid(String versionid) |
| `Description` | `String` | Optional | Description of the target. | String getDescription() | setDescription(String description) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "address": "arn:aws:iam::252156542789:role/ThingSpace",
  "addressscheme": "streamawsiot",
  "createdon": "2019-01-24T19:06:43.577Z",
  "externalid": "lJZnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH==",
  "id": "cea170cc-a58f-6531-fc4b-fae1ceb1a6c8",
  "kind": "ts.target",
  "lastupdated": "2019-01-24T19:32:31.841Z",
  "name": "AWS Target",
  "region": "us-east-1",
  "version": "1.0",
  "versionid": "caf85ff7-200e-11e9-a85b-02420a621e0a",
  "billingaccountid": "billingaccountid0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

