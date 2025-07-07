
# Dto Profile Response

*This model accepts additional fields of type array.*

## Structure

`DtoProfileResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `?string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` | getId(): ?string | setId(?string id): void |
| `kind` | `?string` | Optional | the user defined profile kind | getKind(): ?string | setKind(?string kind): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `?string` | Optional | **Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9\-_]+$` | getVersionid(): ?string | setVersionid(?string versionid): void |
| `createdon` | `?DateTime` | Optional | Timestamp of the record | getCreatedon(): ?\DateTime | setCreatedon(?\DateTime createdon): void |
| `lastupdated` | `?DateTime` | Optional | Timestamp of the record | getLastupdated(): ?\DateTime | setLastupdated(?\DateTime lastupdated): void |
| `name` | `?string` | Optional | user defined profile name | getName(): ?string | setName(?string name): void |
| `foreignid` | `?string` | Optional | UUID of the ECPD account the user belongs to | getForeignid(): ?string | setForeignid(?string foreignid): void |
| `billingaccountid` | `?string` | Optional | The billing account ID. This is the same value as the Account ID | getBillingaccountid(): ?string | setBillingaccountid(?string billingaccountid): void |
| `modelid` | `?string` | Optional | device model id | getModelid(): ?string | setModelid(?string modelid): void |
| `configuration` | `?array` | Optional | - | getConfiguration(): ?array | setConfiguration(?array configuration): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "id": "cb4169ec-eeee-ffff-gggg-d2951060421a",
  "kind": "the kind of profile being created",
  "version": "1.0",
  "versionid": "15bd78a1-eeee-ffff-gggg-86daa842009b",
  "createdon": "10/02/2023 15:46:34",
  "lastupdated": "10/02/2023 15:46:34",
  "name": "Demo Entry sensor 1730928792",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "billingaccountid": "0000123456-00001",
  "modelid": "00000000-0000-0000-0000-000000000019",
  "configuration": {
    "randomInt": 21,
    "resportingInterval": 24
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

