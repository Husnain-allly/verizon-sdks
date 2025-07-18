/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonAnySetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;
import io.apimatic.core.types.AdditionalProperties;
import io.apimatic.core.utilities.ConversionHelper;
import java.util.List;
import java.util.Map;

/**
 * This is a model class for StopMonitorRequest type.
 */
public class StopMonitorRequest {
    private String accountName;
    private List<String> monitorIds;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public StopMonitorRequest() {
    }

    /**
     * Initialization constructor.
     * @param  accountName  String value for accountName.
     * @param  monitorIds  List of String value for monitorIds.
     */
    public StopMonitorRequest(
            String accountName,
            List<String> monitorIds) {
        this.accountName = accountName;
        this.monitorIds = monitorIds;
    }

    /**
     * Getter for AccountName.
     * @return Returns the String
     */
    @JsonGetter("accountName")
    public String getAccountName() {
        return accountName;
    }

    /**
     * Setter for AccountName.
     * @param accountName Value for String
     */
    @JsonSetter("accountName")
    public void setAccountName(String accountName) {
        this.accountName = accountName;
    }

    /**
     * Getter for MonitorIds.
     * @return Returns the List of String
     */
    @JsonGetter("monitorIds")
    public List<String> getMonitorIds() {
        return monitorIds;
    }

    /**
     * Setter for MonitorIds.
     * @param monitorIds Value for List of String
     */
    @JsonSetter("monitorIds")
    public void setMonitorIds(List<String> monitorIds) {
        this.monitorIds = monitorIds;
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
     * Converts this StopMonitorRequest into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "StopMonitorRequest [" + "accountName=" + accountName + ", monitorIds=" + monitorIds
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link StopMonitorRequest.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link StopMonitorRequest.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(accountName, monitorIds);
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link StopMonitorRequest}.
     */
    public static class Builder {
        private String accountName;
        private List<String> monitorIds;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  accountName  String value for accountName.
         * @param  monitorIds  List of String value for monitorIds.
         */
        public Builder(String accountName, List<String> monitorIds) {
            this.accountName = accountName;
            this.monitorIds = monitorIds;
        }

        /**
         * Setter for accountName.
         * @param  accountName  String value for accountName.
         * @return Builder
         */
        public Builder accountName(String accountName) {
            this.accountName = accountName;
            return this;
        }

        /**
         * Setter for monitorIds.
         * @param  monitorIds  List of String value for monitorIds.
         * @return Builder
         */
        public Builder monitorIds(List<String> monitorIds) {
            this.monitorIds = monitorIds;
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
         * Builds a new {@link StopMonitorRequest} object using the set fields.
         * @return {@link StopMonitorRequest}
         */
        public StopMonitorRequest build() {
            StopMonitorRequest model =
                    new StopMonitorRequest(accountName, monitorIds);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
