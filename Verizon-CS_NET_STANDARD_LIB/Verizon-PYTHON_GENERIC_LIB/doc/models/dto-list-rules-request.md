
# Dto List Rules Request

## Structure

`DtoListRulesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `str` | Optional | The numeric account name, which must include leading zeros |
| `filter` | [`DtoFilter`](../../doc/models/dto-filter.md) | Optional | - |
| `resourceidentifier` | [`DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "filter": {
    "$expand": "$expand0",
    "$limitnumber": 100,
    "$nopagination": false,
    "$page": "$page0",
    "$pagenumber": 64
  },
  "resourceidentifier": {
    "id": "id4"
  }
}
```

