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
 * This is a model class for Notify type.
 */
public class Notify {
    private String alertType;
    private List<Carriercode1> threshold;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public Notify() {
    }

    /**
     * Initialization constructor.
     * @param  alertType  String value for alertType.
     * @param  threshold  List of Carriercode1 value for threshold.
     */
    public Notify(
            String alertType,
            List<Carriercode1> threshold) {
        this.alertType = alertType;
        this.threshold = threshold;
    }

    /**
     * Getter for AlertType.
     * @return Returns the String
     */
    @JsonGetter("alertType")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getAlertType() {
        return alertType;
    }

    /**
     * Setter for AlertType.
     * @param alertType Value for String
     */
    @JsonSetter("alertType")
    public void setAlertType(String alertType) {
        this.alertType = alertType;
    }

    /**
     * Getter for Threshold.
     * @return Returns the List of Carriercode1
     */
    @JsonGetter("threshold")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<Carriercode1> getThreshold() {
        return threshold;
    }

    /**
     * Setter for Threshold.
     * @param threshold Value for List of Carriercode1
     */
    @JsonSetter("threshold")
    public void setThreshold(List<Carriercode1> threshold) {
        this.threshold = threshold;
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
     * Converts this Notify into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Notify [" + "alertType=" + alertType + ", threshold=" + threshold
                + ", additionalProperties=" + additionalProperties + "]";
    }

    /**
     * Builds a new {@link Notify.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Notify.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .alertType(getAlertType())
                .threshold(getThreshold());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link Notify}.
     */
    public static class Builder {
        private String alertType;
        private List<Carriercode1> threshold;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for alertType.
         * @param  alertType  String value for alertType.
         * @return Builder
         */
        public Builder alertType(String alertType) {
            this.alertType = alertType;
            return this;
        }

        /**
         * Setter for threshold.
         * @param  threshold  List of Carriercode1 value for threshold.
         * @return Builder
         */
        public Builder threshold(List<Carriercode1> threshold) {
            this.threshold = threshold;
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
         * Builds a new {@link Notify} object using the set fields.
         * @return {@link Notify}
         */
        public Notify build() {
            Notify model =
                    new Notify(alertType, threshold);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
