
# Compute Resources Type

Compute resources of a service profile.

## Structure

`ComputeResourcesType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `gpu` | [`Gpu \| undefined`](../../doc/models/gpu.md) | Optional | GPU resources of a service profile. |
| `minRamgb` | `number \| undefined` | Optional | Minimum RAM required in Gigabytes.<br><br>**Constraints**: `>= 1`, `<= 100` |
| `minStorageGb` | `number \| undefined` | Optional | Minimum storage requirement in Gigabytes.<br><br>**Constraints**: `>= 1`, `<= 100` |

## Example (as JSON)

```json
{
  "minRAMGB": 1,
  "minStorageGB": 1,
  "GPU": {
    "minCoreClockMHz": 76,
    "minMemoryClockMHz": 20,
    "minBandwidthGBs": 96,
    "minTFLOPS": 100
  }
}
```

