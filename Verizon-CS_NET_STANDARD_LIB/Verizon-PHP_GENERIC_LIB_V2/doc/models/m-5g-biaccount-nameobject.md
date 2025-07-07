
# M 5G Biaccount Nameobject

*This model accepts additional fields of type array.*

## Structure

`M5GBiaccountNameobject`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | - | getAccountName(): ?string | setAccountName(?string accountName): void |
| `billingCycleEndDate` | `?string` | Optional | - | getBillingCycleEndDate(): ?string | setBillingCycleEndDate(?string billingCycleEndDate): void |
| `carrierInformation` | [`?(M5GBiCarrierInformation[])`](../../doc/models/m-5g-bi-carrier-information.md) | Optional | - | getCarrierInformation(): ?array | setCarrierInformation(?array carrierInformation): void |
| `connected` | `?bool` | Optional | - | getConnected(): ?bool | setConnected(?bool connected): void |
| `createdAt` | `?string` | Optional | - | getCreatedAt(): ?string | setCreatedAt(?string createdAt): void |
| `customFields` | [M5GBikeyValue1](../../doc/models/m-5g-bikey-value-1.md)[]\|null | Optional | This is Array of a container for any-of cases. | getCustomFields(): ?array | setCustomFields(?array customFields): void |
| `deviceIds` | [M5GBideviceId1](../../doc/models/m-5g-bidevice-id-1.md)[]\|null | Optional | This is Array of a container for any-of cases. | getDeviceIds(): ?array | setDeviceIds(?array deviceIds): void |
| `extendedAttributes` | array<[M5GBiattribute1](../../doc/models/m-5g-biattribute-1.md)\|[M5GBiattribute2](../../doc/models/m-5g-biattribute-2.md)>\|null | Optional | This is Array of a container for any-of cases. | getExtendedAttributes(): ?array | setExtendedAttributes(?array extendedAttributes): void |
| `groupNames` | [`?(GroupName[])`](../../doc/models/group-name.md) | Optional | - | getGroupNames(): ?array | setGroupNames(?array groupNames): void |
| `ipaddress` | `?string` | Optional | - | getIpaddress(): ?string | setIpaddress(?string ipaddress): void |
| `lastActivationBy` | `?string` | Optional | - | getLastActivationBy(): ?string | setLastActivationBy(?string lastActivationBy): void |
| `lastActivationDate` | `?string` | Optional | - | getLastActivationDate(): ?string | setLastActivationDate(?string lastActivationDate): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

