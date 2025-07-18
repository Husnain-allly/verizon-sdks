/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.List;
import java.util.Map;

/**
 * This is a model class for V1ListOfLicensesToRemoveResult type.
 */
public class V1ListOfLicensesToRemoveResult {
    private Integer count;
    private List<String> deviceList;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public V1ListOfLicensesToRemoveResult() {
    }

    /**
     * Initialization constructor.
     * @param  count  Integer value for count.
     * @param  deviceList  List of String value for deviceList.
     */
    public V1ListOfLicensesToRemoveResult(
            Integer count,
            List<String> deviceList) {
        this.count = count;
        this.deviceList = deviceList;
    }

    /**
     * Getter for Count.
     * The total number of devices on the cancellation candidate list.
     * @return Returns the Integer
     */
    @JsonGetter("count")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public Integer getCount() {
        return count;
    }

    /**
     * Setter for Count.
     * The total number of devices on the cancellation candidate list.
     * @param count Value for Integer
     */
    @JsonSetter("count")
    public void setCount(Integer count) {
        this.count = count;
    }

    /**
     * Getter for DeviceList.
     * The IMEIs of the devices.
     * @return Returns the List of String
     */
    @JsonGetter("deviceList")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<String> getDeviceList() {
        return deviceList;
    }

    /**
     * Setter for DeviceList.
     * The IMEIs of the devices.
     * @param deviceList Value for List of String
     */
    @JsonSetter("deviceList")
    public void setDeviceList(List<String> deviceList) {
        this.deviceList = deviceList;
    }

    /**
     * Hidden method for the serialization of additional properties.
     * @return The map of additionally set properties.
     */
    @JsonAnyGetter
    private Map<String, Object> getAdditionalProperties() {
        return additionalProperties.getAdditionalProperties();
    }

    /**
     * Hidden method for the de-serialization of additional properties.
     * @param name The name of the additional property.
     * @param value The Object value of the additional property.
     */
    @JsonAnySetter
    private void setAdditionalProperties(String name, Object value) {
        additionalProperties.setAdditionalProperty(name,
                ConversionHelper.convertToSimpleType(value,
                        x -> x),
                true);
    }

    /**
     * Getter for the value of additional properties based on provided property name.
     * @param name The name of the additional property.
     * @return Either the Object property value or null if not exist.
     */
    
    public Object getAdditionalProperty(String name) {
        return additionalProperties.getAdditionalProperty(name);
    }

    /**
     * Converts this V1ListOfLicensesToRemoveResult into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "V1ListOfLicensesToRemoveResult [" + "count=" + count + ", deviceList=" + deviceList
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link V1ListOfLicensesToRemoveResult.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link V1ListOfLicensesToRemoveResult.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .count(getCount())
                .deviceList(getDeviceList());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link V1ListOfLicensesToRemoveResult}.
     */
    public static class Builder {
        private Integer count;
        private List<String> deviceList;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for count.
         * @param  count  Integer value for count.
         * @return Builder
         */
        public Builder count(Integer count) {
            this.count = count;
            return this;
        }

        /**
         * Setter for deviceList.
         * @param  deviceList  List of String value for deviceList.
         * @return Builder
         */
        public Builder deviceList(List<String> deviceList) {
            this.deviceList = deviceList;
            return this;
        }

        /**
         * Setter for additional property that are not in model fields.
         * @param name The name of the additional property.
         * @param value The Object value of the additional property.
         * @return Builder.
         */
        public Builder additionalProperty(String name, Object value) {
            this.additionalProperties.setAdditionalProperty(name, value);
            return this;
        }

        /**
         * Builds a new {@link V1ListOfLicensesToRemoveResult} object using the set fields.
         * @return {@link V1ListOfLicensesToRemoveResult}
         */
        public V1ListOfLicensesToRemoveResult build() {
            V1ListOfLicensesToRemoveResult model =
                    new V1ListOfLicensesToRemoveResult(count, deviceList);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
