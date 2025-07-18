/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.TreeMap;


/**
 * TriggerCategory to be used.
 */
public enum TriggerCategory {
    ACCOUNTUSAGE,

    DEVICEGROUPUSAGE,

    PRICEPLANDATAUSAGE;


    private static TreeMap<String, TriggerCategory> valueMap = new TreeMap<>();
    private String value;

    static {
        ACCOUNTUSAGE.value = "AccountUsage";
        DEVICEGROUPUSAGE.value = "DeviceGroupUsage";
        PRICEPLANDATAUSAGE.value = "PricePlanDataUsage";

        valueMap.put("AccountUsage", ACCOUNTUSAGE);
        valueMap.put("DeviceGroupUsage", DEVICEGROUPUSAGE);
        valueMap.put("PricePlanDataUsage", PRICEPLANDATAUSAGE);
    }

    /**
     * Returns the enum member associated with the given string value.
     * @param toConvert String value to get enum member.
     * @return The enum member against the given string value.
     * @throws IOException when provided value is not mapped to any enum member.
     */
    @JsonCreator
    public static TriggerCategory constructFromString(String toConvert) throws IOException {
        TriggerCategory enumValue = fromString(toConvert);
        if (enumValue == null) {
            throw new IOException("Unable to create enum instance with value: " + toConvert);
        }
        return enumValue;
    }

    /**
     * Returns the enum member associated with the given string value.
     * @param toConvert String value to get enum member.
     * @return The enum member against the given string value.
     */
    public static TriggerCategory fromString(String toConvert) {
        return valueMap.get(toConvert);
    }

    /**
     * Returns the string value associated with the enum member.
     * @return The string value against enum member.
     */
    @JsonValue
    public String value() {
        return value;
    }
        
    /**
     * Get string representation of this enum.
     */
    @Override
    public String toString() {
        return value.toString();
    }

    /**
     * Convert list of TriggerCategory values to list of string values.
     * @param toConvert The list of TriggerCategory values to convert.
     * @return List of representative string values.
     */
    public static List<String> toValue(List<TriggerCategory> toConvert) {
        if (toConvert == null) {
            return null;
        }
        List<String> convertedValues = new ArrayList<>();
        for (TriggerCategory enumValue : toConvert) {
            convertedValues.add(enumValue.value);
        }
        return convertedValues;
    }
} 