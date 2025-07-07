
# M 5G Biaccount Nameobject

*This model accepts additional fields of type unknown.*

## Structure

`M5GBiaccountNameobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | - |
| `billingCycleEndDate` | `string \| undefined` | Optional | - |
| `carrierInformation` | [`M5GBiCarrierInformation[] \| undefined`](../../doc/models/m-5g-bi-carrier-information.md) | Optional | - |
| `connected` | `boolean \| undefined` | Optional | - |
| `createdAt` | `string \| undefined` | Optional | - |
| `customFields` | [`M5GBiaccountNameobjectCustomFields[] \| undefined`](../../doc/models/containers/m-5g-biaccount-nameobject-custom-fields.md) | Optional | This is Array of a container for any-of cases. |
| `deviceIds` | [`M5GBiaccountNameobjectDeviceIds[] \| undefined`](../../doc/models/containers/m-5g-biaccount-nameobject-device-ids.md) | Optional | This is Array of a container for any-of cases. |
| `extendedAttributes` | [`M5GBiaccountNameobjectExtendedAttributes[] \| undefined`](../../doc/models/containers/m-5g-biaccount-nameobject-extended-attributes.md) | Optional | This is Array of a container for any-of cases. |
| `groupNames` | [`GroupName[] \| undefined`](../../doc/models/group-name.md) | Optional | - |
| `ipaddress` | `string \| undefined` | Optional | - |
| `lastActivationBy` | `string \| undefined` | Optional | - |
| `lastActivationDate` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "billingCycleEndDate": "11/10/2022 00:00:00",
  "connected": false,
  "createdAt": "10/20/2022 18:23:41",
  "ipAddress": "0.0.0.0",
  "lastActivationBy": "User Name",
  "lastActivationDate": "2022-11-02 T21:36:18Z",
  "carrierInformation": [
    {
      "carrierName": "carrierName4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "carrierName": "carrierName4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "carrierName": "carrierName4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

