/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for GeographicalPath type.
 */
public class GeographicalPath {
    private GeographicalPathDescription description;
    private String direction;

    /**
     * Default constructor.
     */
    public GeographicalPath() {
    }

    /**
     * Initialization constructor.
     * @param  description  GeographicalPathDescription value for description.
     * @param  direction  String value for direction.
     */
    public GeographicalPath(
            GeographicalPathDescription description,
            String direction) {
        this.description = description;
        this.direction = direction;
    }

    /**
     * Getter for Description.
     * This data frame can describe a complex path of arbitrary size using node offset method (LL
     * offsets).
     * @return Returns the GeographicalPathDescription
     */
    @JsonGetter("description")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public GeographicalPathDescription getDescription() {
        return description;
    }

    /**
     * Setter for Description.
     * This data frame can describe a complex path of arbitrary size using node offset method (LL
     * offsets).
     * @param description Value for GeographicalPathDescription
     */
    @JsonSetter("description")
    public void setDescription(GeographicalPathDescription description) {
        this.description = description;
    }

    /**
     * Getter for Direction.
     * @return Returns the String
     */
    @JsonGetter("direction")
    @JsonInclude(JsonInclude.Include.NON_NULL)
    public String getDirection() {
        return direction;
    }

    /**
     * Setter for Direction.
     * @param direction Value for String
     */
    @JsonSetter("direction")
    public void setDirection(String direction) {
        this.direction = direction;
    }

    /**
     * Converts this GeographicalPath into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "GeographicalPath [" + "description=" + description + ", direction=" + direction
                + "]";
    }

    /**
     * Builds a new {@link GeographicalPath.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link GeographicalPath.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder()
                .description(getDescription())
                .direction(getDirection());
        return builder;
    }

    /**
     * Class to build instances of {@link GeographicalPath}.
     */
    public static class Builder {
        private GeographicalPathDescription description;
        private String direction;



        /**
         * Setter for description.
         * @param  description  GeographicalPathDescription value for description.
         * @return Builder
         */
        public Builder description(GeographicalPathDescription description) {
            this.description = description;
            return this;
        }

        /**
         * Setter for direction.
         * @param  direction  String value for direction.
         * @return Builder
         */
        public Builder direction(String direction) {
            this.direction = direction;
            return this;
        }

        /**
         * Builds a new {@link GeographicalPath} object using the set fields.
         * @return {@link GeographicalPath}
         */
        public GeographicalPath build() {
            return new GeographicalPath(description, direction);
        }
    }
}
