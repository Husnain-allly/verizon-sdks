# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class SensorInsightsBle(object):

    """Implementation of the 'sensorInsightsBLE' model.

    Property objects for Bluetooth Low-Energy (BLE) devices

    Attributes:
        data_mode (int): The data mode the sensor is using
        manufacturer_id (int): The numeric manufacturer ID
        max_num_scan (int): How frequently the device can be scanned
        min_sig_str (int): The minimum signal strength needed for the sensor
            to transmit (in Decibels or dB)
        monitor_period (int): The ammount of time to monitor the sensor and
            varies by device
        more_manuf_id (List[Any]): Values for the manufacturer and these vary
            by device
        op_mode (int): The operation mode
        report_offset (int): The ammount of time between sensor readings and
            reports
        report_period (int): The ammount of time between reports
        report_type (int): The report type
        scan_duration (int): The ammount of time the sensor is queried for data
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "data_mode": 'dataMode',
        "manufacturer_id": 'manufacturerId',
        "max_num_scan": 'maxNumScan',
        "min_sig_str": 'minSigStr',
        "monitor_period": 'monitorPeriod',
        "more_manuf_id": 'moreManufId',
        "op_mode": 'opMode',
        "report_offset": 'reportOffset',
        "report_period": 'reportPeriod',
        "report_type": 'reportType',
        "scan_duration": 'scanDuration'
    }

    _optionals = [
        'data_mode',
        'manufacturer_id',
        'max_num_scan',
        'min_sig_str',
        'monitor_period',
        'more_manuf_id',
        'op_mode',
        'report_offset',
        'report_period',
        'report_type',
        'scan_duration',
    ]

    def __init__(self,
                 data_mode=APIHelper.SKIP,
                 manufacturer_id=APIHelper.SKIP,
                 max_num_scan=APIHelper.SKIP,
                 min_sig_str=APIHelper.SKIP,
                 monitor_period=APIHelper.SKIP,
                 more_manuf_id=APIHelper.SKIP,
                 op_mode=APIHelper.SKIP,
                 report_offset=APIHelper.SKIP,
                 report_period=APIHelper.SKIP,
                 report_type=APIHelper.SKIP,
                 scan_duration=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the SensorInsightsBle class"""

        # Initialize members of the class
        if data_mode is not APIHelper.SKIP:
            self.data_mode = data_mode 
        if manufacturer_id is not APIHelper.SKIP:
            self.manufacturer_id = manufacturer_id 
        if max_num_scan is not APIHelper.SKIP:
            self.max_num_scan = max_num_scan 
        if min_sig_str is not APIHelper.SKIP:
            self.min_sig_str = min_sig_str 
        if monitor_period is not APIHelper.SKIP:
            self.monitor_period = monitor_period 
        if more_manuf_id is not APIHelper.SKIP:
            self.more_manuf_id = more_manuf_id 
        if op_mode is not APIHelper.SKIP:
            self.op_mode = op_mode 
        if report_offset is not APIHelper.SKIP:
            self.report_offset = report_offset 
        if report_period is not APIHelper.SKIP:
            self.report_period = report_period 
        if report_type is not APIHelper.SKIP:
            self.report_type = report_type 
        if scan_duration is not APIHelper.SKIP:
            self.scan_duration = scan_duration 

        # Add additional model properties to the instance
        if additional_properties is None:
            additional_properties = {}
        self.additional_properties = additional_properties

    @classmethod
    def from_dictionary(cls,
                        dictionary):
        """Creates an instance of this model from a dictionary

        Args:
            dictionary (dictionary): A dictionary representation of the object
            as obtained from the deserialization of the server's response. The
            keys MUST match property names in the API description.

        Returns:
            object: An instance of this structure class.

        """

        if not isinstance(dictionary, dict) or dictionary is None:
            return None

        # Extract variables from the dictionary
        data_mode = dictionary.get("dataMode") if dictionary.get("dataMode") else APIHelper.SKIP
        manufacturer_id = dictionary.get("manufacturerId") if dictionary.get("manufacturerId") else APIHelper.SKIP
        max_num_scan = dictionary.get("maxNumScan") if dictionary.get("maxNumScan") else APIHelper.SKIP
        min_sig_str = dictionary.get("minSigStr") if dictionary.get("minSigStr") else APIHelper.SKIP
        monitor_period = dictionary.get("monitorPeriod") if dictionary.get("monitorPeriod") else APIHelper.SKIP
        more_manuf_id = dictionary.get("moreManufId") if dictionary.get("moreManufId") else APIHelper.SKIP
        op_mode = dictionary.get("opMode") if dictionary.get("opMode") else APIHelper.SKIP
        report_offset = dictionary.get("reportOffset") if dictionary.get("reportOffset") else APIHelper.SKIP
        report_period = dictionary.get("reportPeriod") if dictionary.get("reportPeriod") else APIHelper.SKIP
        report_type = dictionary.get("reportType") if dictionary.get("reportType") else APIHelper.SKIP
        scan_duration = dictionary.get("scanDuration") if dictionary.get("scanDuration") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(data_mode,
                   manufacturer_id,
                   max_num_scan,
                   min_sig_str,
                   monitor_period,
                   more_manuf_id,
                   op_mode,
                   report_offset,
                   report_period,
                   report_type,
                   scan_duration,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'data_mode={(self.data_mode if hasattr(self, "data_mode") else None)!r}, '
                f'manufacturer_id={(self.manufacturer_id if hasattr(self, "manufacturer_id") else None)!r}, '
                f'max_num_scan={(self.max_num_scan if hasattr(self, "max_num_scan") else None)!r}, '
                f'min_sig_str={(self.min_sig_str if hasattr(self, "min_sig_str") else None)!r}, '
                f'monitor_period={(self.monitor_period if hasattr(self, "monitor_period") else None)!r}, '
                f'more_manuf_id={(self.more_manuf_id if hasattr(self, "more_manuf_id") else None)!r}, '
                f'op_mode={(self.op_mode if hasattr(self, "op_mode") else None)!r}, '
                f'report_offset={(self.report_offset if hasattr(self, "report_offset") else None)!r}, '
                f'report_period={(self.report_period if hasattr(self, "report_period") else None)!r}, '
                f'report_type={(self.report_type if hasattr(self, "report_type") else None)!r}, '
                f'scan_duration={(self.scan_duration if hasattr(self, "scan_duration") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'data_mode={(self.data_mode if hasattr(self, "data_mode") else None)!s}, '
                f'manufacturer_id={(self.manufacturer_id if hasattr(self, "manufacturer_id") else None)!s}, '
                f'max_num_scan={(self.max_num_scan if hasattr(self, "max_num_scan") else None)!s}, '
                f'min_sig_str={(self.min_sig_str if hasattr(self, "min_sig_str") else None)!s}, '
                f'monitor_period={(self.monitor_period if hasattr(self, "monitor_period") else None)!s}, '
                f'more_manuf_id={(self.more_manuf_id if hasattr(self, "more_manuf_id") else None)!s}, '
                f'op_mode={(self.op_mode if hasattr(self, "op_mode") else None)!s}, '
                f'report_offset={(self.report_offset if hasattr(self, "report_offset") else None)!s}, '
                f'report_period={(self.report_period if hasattr(self, "report_period") else None)!s}, '
                f'report_type={(self.report_type if hasattr(self, "report_type") else None)!s}, '
                f'scan_duration={(self.scan_duration if hasattr(self, "scan_duration") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
