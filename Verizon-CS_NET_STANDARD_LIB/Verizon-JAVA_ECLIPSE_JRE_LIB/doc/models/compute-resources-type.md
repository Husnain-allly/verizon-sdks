
# Compute Resources Type

Compute resources of a service profile.

## Structure

`ComputeResourcesType`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Gpu` | [`Gpu`](../../doc/models/gpu.md) | Optional | GPU resources of a service profile. | Gpu getGpu() | setGpu(Gpu gpu) |
| `MinRamgb` | `Integer` | Optional | Minimum RAM required in Gigabytes.<br><br>**Constraints**: `>= 1`, `<= 100` | Integer getMinRamgb() | setMinRamgb(Integer minRamgb) |
| `MinStorageGb` | `Integer` | Optional | Minimum storage requirement in Gigabytes.<br><br>**Constraints**: `>= 1`, `<= 100` | Integer getMinStorageGb() | setMinStorageGb(Integer minStorageGb) |

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

