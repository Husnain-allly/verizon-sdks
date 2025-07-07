
# Dto Patch Smart Alert Request

## Structure

`DtoPatchSmartAlertRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountname` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountname() | setAccountname(String accountname) |
| `Resourceidentifier` | [`DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - | DtoResourceidentifier getResourceidentifier() | setResourceidentifier(DtoResourceidentifier resourceidentifier) |
| `Smartalert` | [`UserSmartAlert`](../../doc/models/user-smart-alert.md) | Optional | - | UserSmartAlert getSmartalert() | setSmartalert(UserSmartAlert smartalert) |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "resourceidentifier": {
    "id": "id4"
  },
  "smartalert": {
    "accountclientid": "accountclientid6",
    "billingaccountid": "billingaccountid6",
    "category": "category8",
    "condition": 154,
    "createdon": "2016-03-13T12:52:32.123Z",
    "description": "description0",
    "lastupdated": "2016-03-13T12:52:32.123Z",
    "versionid": "versionid2"
  }
}
```

