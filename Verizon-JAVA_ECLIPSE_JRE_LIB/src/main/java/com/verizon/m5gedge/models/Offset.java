/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.models;

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

/**
 * This is a model class for Offset type.
 */
public class Offset {
    private NodeListLl ll;

    /**
     * Default constructor.
     */
    public Offset() {
    }

    /**
     * Initialization constructor.
     * @param  ll  NodeListLl value for ll.
     */
    public Offset(
            NodeListLl ll) {
        this.ll = ll;
    }

    /**
     * Getter for Ll.
     * The NodeListLL data structure provides the sequence of signed offset node point values for
     * determining the latitude and longitude. Each LL point is referred to as a node point.
     * @return Returns the NodeListLl
     */
    @JsonGetter("ll")
    public NodeListLl getLl() {
        return ll;
    }

    /**
     * Setter for Ll.
     * The NodeListLL data structure provides the sequence of signed offset node point values for
     * determining the latitude and longitude. Each LL point is referred to as a node point.
     * @param ll Value for NodeListLl
     */
    @JsonSetter("ll")
    public void setLl(NodeListLl ll) {
        this.ll = ll;
    }

    /**
     * Converts this Offset into string format.
     * @return String representation of this class
     */
    @Override
    public String toString() {
        return "Offset [" + "ll=" + ll + "]";
    }

    /**
     * Builds a new {@link Offset.Builder} object.
     * Creates the instance with the state of the current model.
     * @return a new {@link Offset.Builder} object
     */
    public Builder toBuilder() {
        Builder builder = new Builder(ll);
        return builder;
    }

    /**
     * Class to build instances of {@link Offset}.
     */
    public static class Builder {
        private NodeListLl ll;

        /**
         * Initialization constructor.
         */
        public Builder() {
        }

        /**
         * Initialization constructor.
         * @param  ll  NodeListLl value for ll.
         */
        public Builder(NodeListLl ll) {
            this.ll = ll;
        }

        /**
         * Setter for ll.
         * @param  ll  NodeListLl value for ll.
         * @return Builder
         */
        public Builder ll(NodeListLl ll) {
            this.ll = ll;
            return this;
        }

        /**
         * Builds a new {@link Offset} object using the set fields.
         * @return {@link Offset}
         */
        public Offset build() {
            return new Offset(ll);
        }
    }
}
