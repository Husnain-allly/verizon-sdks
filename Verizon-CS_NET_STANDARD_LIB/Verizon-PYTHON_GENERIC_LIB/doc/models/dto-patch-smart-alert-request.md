
# Dto Patch Smart Alert Request

## Structure

`DtoPatchSmartAlertRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `str` | Optional | The numeric account name, which must include leading zeros |
| `resourceidentifier` | [`DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - |
| `smartalert` | [`UserSmartAlert`](../../doc/models/user-smart-alert.md) | Optional | - |

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

