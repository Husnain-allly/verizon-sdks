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
 * This is a model class for PwnProfileList type.
 */
public class PwnProfileList {
    private List<PwnProfile> profiles;
    private AdditionalProperties<Object> additionalProperties = 
            new AdditionalProperties<Object>(this.getClass());

    /**
     * Default constructor.
     */
    public PwnProfileList() {
    }

    /**
     * Initialization constructor.
     * @param  profiles  List of PwnProfile value for profiles.
     */
    public PwnProfileList(
            List<PwnProfile> profiles) {
        this.profiles = profiles;
    }

    /**
     * Getter for Profiles.
     * @return Returns the List of PwnProfile
     */
    @JsonGetter("profiles")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public List<PwnProfile> getProfiles() {
        return profiles;
    }

    /**
     * Setter for Profiles.
     * @param profiles Value for List of PwnProfile
     */
    @JsonSetter("profiles")
    public void setProfiles(List<PwnProfile> profiles) {
        this.profiles = profiles;
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
     * Converts this PwnProfileList into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "PwnProfileList [" + "profiles=" + profiles + ", additionalProperties="
                + additionalProperties + "]";
    }

    /**
     * Builds a new {@link PwnProfileList.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link PwnProfileList.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .profiles(getProfiles());
        builder.additionalProperties = additionalProperties;
        return builder;
    }

    /**
     * Class to build instances of {@link PwnProfileList}.
     */
    public static class Builder {
        private List<PwnProfile> profiles;
        private AdditionalProperties<Object> additionalProperties =
                new AdditionalProperties<Object>();



        /**
         * Setter for profiles.
         * @param  profiles  List of PwnProfile value for profiles.
         * @return Builder
         */
        public Builder profiles(List<PwnProfile> profiles) {
            this.profiles = profiles;
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
         * Builds a new {@link PwnProfileList} object using the set fields.
         * @return {@link PwnProfileList}
         */
        public PwnProfileList build() {
            PwnProfileList model =
                    new PwnProfileList(profiles);
            model.additionalProperties = additionalProperties;
            return model;
        }
    }
}
