<?php

declare(strict_types=1);

/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

namespace VerizonLib\Models;

use Core\Utils\CoreHelper;
use Exception;
use stdClass;

/**
 * The type of the client that is to be registered. This is one of the major traffic participant groups
 * considered in V2X communication. The system uses this value to define which topics the client will
 * be able to publish and subscribe to.
 *
 * Values:
 * - **Vehicle** - Vehicle with an enclosure around the passengers. (Subtypes: PassengerCar, Truck, Bus,
 * EmergencyVehicle, SchoolBus, MaintenanceVehicle)
 * - **VulnerableRoadUser** - Traffic participants without a protecting enclosure. (Subtypes:
 * Motorcycle, Bicycle, Pedestrian, Scooter)
 * - **TrafficLightController** - A Traffic light controller system. (Subtypes: NA)
 * - **InfrastructureSensor** - Sensors that are deployed in the infrastructure. (Subtypes:
 * RoadSideUnit, Camera, Lidar, Radar, InductiveLoop, MagneticSensor)
 * - **OnboardSensor** - Sensors that are onboard on a vehicle(Subtypes: Camera, Lidar, Radar)
 * - **Software** - A software system or application. (Subtypes: Platform, Application, NA)
 */
class EtxClientType
{
    public const VEHICLE = 'Vehicle';

    public const VULNERABLEROADUSER = 'VulnerableRoadUser';

    public const TRAFFICLIGHTCONTROLLER = 'TrafficLightController';

    public const INFRASTRUCTURESENSOR = 'InfrastructureSensor';

    public const ONBOARDSENSOR = 'OnboardSensor';

    public const SOFTWARE = 'Software';

    private const _ALL_VALUES = [
        self::VEHICLE,
        self::VULNERABLEROADUSER,
        self::TRAFFICLIGHTCONTROLLER,
        self::INFRASTRUCTURESENSOR,
        self::ONBOARDSENSOR,
        self::SOFTWARE
    ];

    /**
     * Ensures that all the given values are present in this Enum.
     *
     * @param array|stdClass|null|string $value Value or a list/map of values to be checked
     *
     * @return array|null|string Input value(s), if all are a part of this Enum
     *
     * @throws Exception Throws exception if any given value is not in this Enum
     */
    public static function checkValue($value)
    {
        $value = json_decode(json_encode($value), true); // converts stdClass into array
        if (CoreHelper::checkValueOrValuesInList($value, self::_ALL_VALUES)) {
            return $value;
        }
        throw new Exception("$value is invalid for EtxClientType.");
    }
}
