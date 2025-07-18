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
import java.util.Map;

/**
 * This is a model class for Onboarding type.
 */
public class Onboarding {
    private String sensoridentifier;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public Onboarding() {
    }

    /**
     * Initialization constructor.
     * @param  sensoridentifier  String value for sensoridentifier.
     */
    public Onboarding(
            String sensoridentifier) {
        this.sensoridentifier = sensoridentifier;
    }

    /**
     * Getter for Sensoridentifier.
     * the IEEE EUI64 address space used to identify a device. It is supplied by the device
     * manufacturer
     * @return Returns the String
     */
    @JsonGetter("sensoridentifier")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getSensoridentifier() {
        return sensoridentifier;
    }

    /**
     * Setter for Sensoridentifier.
     * the IEEE EUI64 address space used to identify a device. It is supplied by the device
     * manufacturer
     * @param sensoridentifier Value for String
     */
    @JsonSetter("sensoridentifier")
    public void setSensoridentifier(String sensoridentifier) {
        this.sensoridentifier = sensoridentifier;
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
     * Converts this Onboarding into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Onboarding [" + "sensoridentifier=" + sensoridentifier + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link Onboarding.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Onboarding.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .sensoridentifier(getSensoridentifier());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link Onboarding}.
     */
    public static class Builder {
        private String sensoridentifier;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for sensoridentifier.
         * @param  sensoridentifier  String value for sensoridentifier.
         * @return Builder
         */
        public Builder sensoridentifier(String sensoridentifier) {
            this.sensoridentifier = sensoridentifier;
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
         * Builds a new {@link Onboarding} object using the set fields.
         * @return {@link Onboarding}
         */
        public Onboarding build() {
            Onboarding model =
                    new Onboarding(sensoridentifier);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
