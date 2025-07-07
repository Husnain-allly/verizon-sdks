
# User Device Experience History

## Structure

`UserDeviceExperienceHistory`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `billingaccountid` | `?string` | Optional | The billing account ID. This is the same value as the Account ID | getBillingaccountid(): ?string | setBillingaccountid(?string billingaccountid): void |
| `createdon` | `?DateTime` | Optional | Timestamp of the record | getCreatedon(): ?\DateTime | setCreatedon(?\DateTime createdon): void |
| `date` | `?DateTime` | Optional | Timestamp of the record | getDate(): ?\DateTime | setDate(?\DateTime date): void |
| `devicesbad` | `?int` | Optional | This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have failed | getDevicesbad(): ?int | setDevicesbad(?int devicesbad): void |
| `devicesfair` | `?int` | Optional | This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that are impaired | getDevicesfair(): ?int | setDevicesfair(?int devicesfair): void |
| `devicesgood` | `?int` | Optional | This is a score based on combination of network coverage and network outage affecting the device's ability to connect to the network. This is a count of devices that have no issues | getDevicesgood(): ?int | setDevicesgood(?int devicesgood): void |
| `devicestotal` | `?int` | Optional | A count of all devices | getDevicestotal(): ?int | setDevicestotal(?int devicestotal): void |
| `foreignid` | `?string` | Optional | UUID of the ECPD account the user belongs to | getForeignid(): ?string | setForeignid(?string foreignid): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `lastupdated` | `?DateTime` | Optional | Timestamp of the record | getLastupdated(): ?\DateTime | setLastupdated(?\DateTime lastupdated): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `?string` | Optional | The UUID of the resource version | getVersionid(): ?string | setVersionid(?string versionid): void |

## Example (as JSON)

```json
{
  "billingaccountid": "0000123456-00001",
  "createdon": "10/02/2023 15:46:34",
  "date": "10/02/2023 15:46:34",
  "devicesbad": 2,
  "devicesfair": 2,
  "devicesgood": 8,
  "devicestotal": 12,
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "lastupdated": "10/02/2023 15:46:34",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395"
}
```

