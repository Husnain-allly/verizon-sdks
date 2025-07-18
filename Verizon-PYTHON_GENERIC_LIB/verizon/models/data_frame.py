# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.geographical_path import GeographicalPath


class DataFrame(object):

    """Implementation of the 'DataFrame' model.

    The data frame allows sending various advisory and road sign types of
    information to equipped devices.

    Attributes:
        not_used (int): Always set to 0 and carries no meaning. Legacy field
            maintained for backward compatibility.
        frame_type (FrameType): The frameType data element provides the type
            of message to follow in the rest of the message frame structure.
            The following frame types are supported:  - unknown  - advisory  -
            roadSignage  - commercialSignage
        msg_id (Any): The model property of type Any.
        start_year (int): The V2X year consists of integer values from zero to
            4095 representing the year according to the Gregorian calendar
            date system. The value of zero shall represent an unknown value.
        start_time (int): Start time expresses the number of elapsed minutes
            of the current year in the time system being used (typically UTC
            time). The value 527040 shall be used for invalid.
        duration_time (int): The duration, in units of whole minutes, that a
            object persists for. A value of 32000 means that the object
            persists forever. The range 0..32000 provides for about 22.2 days
            of maximum duration.
        priority (int): The relative importance of the sign, on a scale from
            zero (least important) to seven (most important).
        not_used_1 (int): Always set to 0 and carries no meaning. Legacy field
            maintained for backward compatibility.
        regions (List[GeographicalPath]): The data frame is used to support
            the cross-cutting need in many V2X messages to describe arbitrary
            spatial areas (polygons, boundary lines, and other basic shapes)
            required by various message types in a small message size. This
            data frame can describe a complex path or region of arbitrary size
            using either one of the two supported node offset methods (XY
            offsets or LL offsets) or using simple geometric projections.
        not_used_2 (int): Always set to 0 and carries no meaning. Legacy field
            maintained for backward compatibility.
        not_used_3 (int): Always set to 0 and carries no meaning. Legacy field
            maintained for backward compatibility.
        content (Any): The model property of type Any.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "not_used": 'notUsed',
        "frame_type": 'frameType',
        "msg_id": 'msgId',
        "start_time": 'startTime',
        "duration_time": 'durationTime',
        "priority": 'priority',
        "not_used_1": 'notUsed1',
        "regions": 'regions',
        "not_used_2": 'notUsed2',
        "not_used_3": 'notUsed3',
        "content": 'content',
        "start_year": 'startYear'
    }

    _optionals = [
        'start_year',
    ]

    def __init__(self,
                 not_used=None,
                 frame_type=None,
                 msg_id=None,
                 start_time=None,
                 duration_time=None,
                 priority=None,
                 not_used_1=None,
                 regions=None,
                 not_used_2=None,
                 not_used_3=None,
                 content=None,
                 start_year=APIHelper.SKIP):
        """Constructor for the DataFrame class"""

        # Initialize members of the class
        self.not_used = not_used 
        self.frame_type = frame_type 
        self.msg_id = msg_id 
        if start_year is not APIHelper.SKIP:
            self.start_year = start_year 
        self.start_time = start_time 
        self.duration_time = duration_time 
        self.priority = priority 
        self.not_used_1 = not_used_1 
        self.regions = regions 
        self.not_used_2 = not_used_2 
        self.not_used_3 = not_used_3 
        self.content = content 

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
        not_used = dictionary.get("notUsed") if dictionary.get("notUsed") else None
        frame_type = dictionary.get("frameType") if dictionary.get("frameType") else None
        msg_id = dictionary.get("msgId") if dictionary.get("msgId") else None
        start_time = dictionary.get("startTime") if dictionary.get("startTime") else None
        duration_time = dictionary.get("durationTime") if dictionary.get("durationTime") else None
        priority = dictionary.get("priority") if dictionary.get("priority") else None
        not_used_1 = dictionary.get("notUsed1") if dictionary.get("notUsed1") else None
        regions = None
        if dictionary.get('regions') is not None:
            regions = [GeographicalPath.from_dictionary(x) for x in dictionary.get('regions')]
        not_used_2 = dictionary.get("notUsed2") if dictionary.get("notUsed2") else None
        not_used_3 = dictionary.get("notUsed3") if dictionary.get("notUsed3") else None
        content = dictionary.get("content") if dictionary.get("content") else None
        start_year = dictionary.get("startYear") if dictionary.get("startYear") else APIHelper.SKIP
        # Return an object of this model
        return cls(not_used,
                   frame_type,
                   msg_id,
                   start_time,
                   duration_time,
                   priority,
                   not_used_1,
                   regions,
                   not_used_2,
                   not_used_3,
                   content,
                   start_year)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'not_used={self.not_used!r}, '
                f'frame_type={self.frame_type!r}, '
                f'msg_id={self.msg_id!r}, '
                f'start_year={(self.start_year if hasattr(self, "start_year") else None)!r}, '
                f'start_time={self.start_time!r}, '
                f'duration_time={self.duration_time!r}, '
                f'priority={self.priority!r}, '
                f'not_used_1={self.not_used_1!r}, '
                f'regions={self.regions!r}, '
                f'not_used_2={self.not_used_2!r}, '
                f'not_used_3={self.not_used_3!r}, '
                f'content={self.content!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'not_used={self.not_used!s}, '
                f'frame_type={self.frame_type!s}, '
                f'msg_id={self.msg_id!s}, '
                f'start_year={(self.start_year if hasattr(self, "start_year") else None)!s}, '
                f'start_time={self.start_time!s}, '
                f'duration_time={self.duration_time!s}, '
                f'priority={self.priority!s}, '
                f'not_used_1={self.not_used_1!s}, '
                f'regions={self.regions!s}, '
                f'not_used_2={self.not_used_2!s}, '
                f'not_used_3={self.not_used_3!s}, '
                f'content={self.content!s})')
