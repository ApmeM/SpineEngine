namespace SpineEngine.Maths
{
    using System;
    using System.Diagnostics;

    using Microsoft.Xna.Framework;

    /// <summary>
    ///     Describes a 2D-rectangle.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebugDisplayString) + ",nq}")]
    public struct RectangleF : IEquatable<RectangleF>
    {
        /// <summary>
        ///     The x coordinate of the top-left corner of this <see cref="RectangleF" />.
        /// </summary>
        public float X;

        /// <summary>
        ///     The y coordinate of the top-left corner of this <see cref="RectangleF" />.
        /// </summary>
        public float Y;

        /// <summary>
        ///     The width of this <see cref="RectangleF" />.
        /// </summary>
        public float Width;

        /// <summary>
        ///     The height of this <see cref="RectangleF" />.
        /// </summary>
        public float Height;

        /// <summary>
        ///     Returns a <see cref="RectangleF" /> with X=0, Y=0, Width=0, Height=0.
        /// </summary>
        public static RectangleF Empty { get; } = new RectangleF();

        /// <summary>
        ///     Returns a <see cref="RectangleF" /> with X=0, Y=0, Width=1, Height=1.
        /// </summary>
        public static RectangleF One { get; } = new RectangleF(0, 0, 1, 1);

        /// <summary>
        ///     Returns the x coordinate of the left edge of this <see cref="RectangleF" />.
        /// </summary>
        public float Left => this.X;

        /// <summary>
        ///     Returns the x coordinate of the right edge of this <see cref="RectangleF" />.
        /// </summary>
        public float Right => this.X + this.Width;

        /// <summary>
        ///     Returns the y coordinate of the top edge of this <see cref="RectangleF" />.
        /// </summary>
        public float Top => this.Y;

        /// <summary>
        ///     Returns the y coordinate of the bottom edge of this <see cref="RectangleF" />.
        /// </summary>
        public float Bottom => this.Y + this.Height;

        /// <summary>
        ///     Whether or not this <see cref="RectangleF" /> has a <see cref="Width" /> and
        ///     <see cref="Height" /> of 0, and a <see cref="Location" /> of (0, 0).
        /// </summary>
        public bool IsEmpty => this.Width == 0 && this.Height == 0 && this.X == 0 && this.Y == 0;

        /// <summary>
        ///     The top-left coordinates of this <see cref="RectangleF" />.
        /// </summary>
        public Vector2 Location
        {
            get => new Vector2(this.X, this.Y);
            set
            {
                this.X = value.X;
                this.Y = value.Y;
            }
        }

        /// <summary>
        ///     The width-height coordinates of this <see cref="RectangleF" />.
        /// </summary>
        public Vector2 Size
        {
            get => new Vector2(this.Width, this.Height);
            set
            {
                this.Width = value.X;
                this.Height = value.Y;
            }
        }

        /// <summary>
        ///     Creates a new instance of <see cref="RectangleF" /> struct, with the specified
        ///     position, width, and height.
        /// </summary>
        /// <param name="x">The x coordinate of the top-left corner of the created <see cref="RectangleF" />.</param>
        /// <param name="y">The y coordinate of the top-left corner of the created <see cref="RectangleF" />.</param>
        /// <param name="width">The width of the created <see cref="RectangleF" />.</param>
        /// <param name="height">The height of the created <see cref="RectangleF" />.</param>
        public RectangleF(float x, float y, float width, float height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        ///     Creates a new instance of <see cref="RectangleF" /> struct, with the specified
        ///     location and size.
        /// </summary>
        /// <param name="location">The x and y coordinates of the top-left corner of the created <see cref="RectangleF" />.</param>
        /// <param name="size">The width and height of the created <see cref="RectangleF" />.</param>
        public RectangleF(Vector2 location, Vector2 size)
        {
            this.X = location.X;
            this.Y = location.Y;
            this.Width = size.X;
            this.Height = size.Y;
        }

        #region Public Methods

        /// <summary>
        ///     Gets whether or not the provided coordinates lie within the bounds of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="x">The x coordinate of the point to check for containment.</param>
        /// <param name="y">The y coordinate of the point to check for containment.</param>
        /// <returns><c>true</c> if the provided coordinates lie inside this <see cref="RectangleF" />; <c>false</c> otherwise.</returns>
        public bool Contains(int x, int y)
        {
            return this.X <= x && x < this.X + this.Width && this.Y <= y && y < this.Y + this.Height;
        }

        /// <summary>
        ///     Gets whether or not the provided coordinates lie within the bounds of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="x">The x coordinate of the point to check for containment.</param>
        /// <param name="y">The y coordinate of the point to check for containment.</param>
        /// <returns><c>true</c> if the provided coordinates lie inside this <see cref="RectangleF" />; <c>false</c> otherwise.</returns>
        public bool Contains(float x, float y)
        {
            return this.X <= x && x < this.X + this.Width && this.Y <= y && y < this.Y + this.Height;
        }

        /// <summary>
        ///     Gets whether or not the provided <see cref="Point" /> lies within the bounds of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="value">The coordinates to check for inclusion in this <see cref="RectangleF" />.</param>
        /// <returns>
        ///     <c>true</c> if the provided <see cref="Point" /> lies inside this <see cref="RectangleF" />; <c>false</c>
        ///     otherwise.
        /// </returns>
        public bool Contains(Point value)
        {
            return this.X <= value.X && value.X < this.X + this.Width && this.Y <= value.Y
                   && value.Y < this.Y + this.Height;
        }

        /// <summary>
        ///     Gets whether or not the provided <see cref="Point" /> lies within the bounds of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="value">The coordinates to check for inclusion in this <see cref="RectangleF" />.</param>
        /// <param name="result">
        ///     <c>true</c> if the provided <see cref="Point" /> lies inside this <see cref="RectangleF" />;
        ///     <c>false</c> otherwise. As an output parameter.
        /// </param>
        public void Contains(ref Point value, out bool result)
        {
            result = this.X <= value.X && value.X < this.X + this.Width && this.Y <= value.Y
                     && value.Y < this.Y + this.Height;
        }

        /// <summary>
        ///     Gets whether or not the provided <see cref="Vector2" /> lies within the bounds of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="value">The coordinates to check for inclusion in this <see cref="RectangleF" />.</param>
        /// <returns>
        ///     <c>true</c> if the provided <see cref="Vector2" /> lies inside this <see cref="RectangleF" />; <c>false</c>
        ///     otherwise.
        /// </returns>
        public bool Contains(Vector2 value)
        {
            return this.X <= value.X && value.X < this.X + this.Width && this.Y <= value.Y
                   && value.Y < this.Y + this.Height;
        }

        /// <summary>
        ///     Gets whether or not the provided <see cref="Vector2" /> lies within the bounds of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="value">The coordinates to check for inclusion in this <see cref="RectangleF" />.</param>
        /// <param name="result">
        ///     <c>true</c> if the provided <see cref="Vector2" /> lies inside this <see cref="RectangleF" />;
        ///     <c>false</c> otherwise. As an output parameter.
        /// </param>
        public void Contains(ref Vector2 value, out bool result)
        {
            result = this.X <= value.X && value.X < this.X + this.Width && this.Y <= value.Y
                     && value.Y < this.Y + this.Height;
        }

        /// <summary>
        ///     Gets whether or not the provided <see cref="RectangleF" /> lies within the bounds of this <see cref="RectangleF" />
        ///     .
        /// </summary>
        /// <param name="value">The <see cref="RectangleF" /> to check for inclusion in this <see cref="RectangleF" />.</param>
        /// <returns>
        ///     <c>true</c> if the provided <see cref="RectangleF" />'s bounds lie entirely inside this
        ///     <see cref="RectangleF" />; <c>false</c> otherwise.
        /// </returns>
        public bool Contains(RectangleF value)
        {
            return this.X <= value.X && value.X + value.Width <= this.X + this.Width && this.Y <= value.Y
                   && value.Y + value.Height <= this.Y + this.Height;
        }

        /// <summary>
        ///     Gets whether or not the provided <see cref="RectangleF" /> lies within the bounds of this <see cref="RectangleF" />
        ///     .
        /// </summary>
        /// <param name="value">The <see cref="RectangleF" /> to check for inclusion in this <see cref="RectangleF" />.</param>
        /// <param name="result">
        ///     <c>true</c> if the provided <see cref="RectangleF" />'s bounds lie entirely inside this
        ///     <see cref="RectangleF" />; <c>false</c> otherwise. As an output parameter.
        /// </param>
        public void Contains(ref RectangleF value, out bool result)
        {
            result = this.X <= value.X && value.X + value.Width <= this.X + this.Width && this.Y <= value.Y
                     && value.Y + value.Height <= this.Y + this.Height;
        }

        /// <summary>
        ///     Compares whether current instance is equal to specified <see cref="Object" />.
        /// </summary>
        /// <param name="obj">The <see cref="Object" /> to compare.</param>
        /// <returns><c>true</c> if the instances are equal; <c>false</c> otherwise.</returns>
        public override bool Equals(object obj)
        {
            return obj is RectangleF rect && this == rect;
        }

        /// <summary>
        ///     Compares whether current instance is equal to specified <see cref="RectangleF" />.
        /// </summary>
        /// <param name="other">The <see cref="RectangleF" /> to compare.</param>
        /// <returns><c>true</c> if the instances are equal; <c>false</c> otherwise.</returns>
        public bool Equals(RectangleF other)
        {
            return this == other;
        }

        /// <summary>
        ///     Gets the hash code of this <see cref="RectangleF" />.
        /// </summary>
        /// <returns>Hash code of this <see cref="RectangleF" />.</returns>
        public override int GetHashCode()
        {
            return (int)this.X ^ (int)this.Y ^ (int)this.Width ^ (int)this.Height;
        }

        /// <summary>
        ///     Adjusts the edges of this <see cref="RectangleF" /> by specified horizontal and vertical amounts.
        /// </summary>
        /// <param name="horizontalAmount">Value to adjust the left and right edges.</param>
        /// <param name="verticalAmount">Value to adjust the top and bottom edges.</param>
        public void Inflate(int horizontalAmount, int verticalAmount)
        {
            this.X -= horizontalAmount;
            this.Y -= verticalAmount;
            this.Width += horizontalAmount * 2;
            this.Height += verticalAmount * 2;
        }

        /// <summary>
        ///     Adjusts the edges of this <see cref="RectangleF" /> by specified horizontal and vertical amounts.
        /// </summary>
        /// <param name="horizontalAmount">Value to adjust the left and right edges.</param>
        /// <param name="verticalAmount">Value to adjust the top and bottom edges.</param>
        public void Inflate(float horizontalAmount, float verticalAmount)
        {
            this.X -= horizontalAmount;
            this.Y -= verticalAmount;
            this.Width += horizontalAmount * 2;
            this.Height += verticalAmount * 2;
        }

        /// <summary>
        ///     Gets whether or not the other <see cref="RectangleF" /> intersects with this rectangle.
        /// </summary>
        /// <param name="value">The other rectangle for testing.</param>
        /// <returns><c>true</c> if other <see cref="RectangleF" /> intersects with this rectangle; <c>false</c> otherwise.</returns>
        public bool Intersects(RectangleF value)
        {
            return value.Left < this.Right && this.Left < value.Right && value.Top < this.Bottom
                   && this.Top < value.Bottom;
        }

        /// <summary>
        ///     Gets whether or not the other <see cref="RectangleF" /> intersects with this rectangle.
        /// </summary>
        /// <param name="value">The other rectangle for testing.</param>
        /// <param name="result">
        ///     <c>true</c> if other <see cref="RectangleF" /> intersects with this rectangle; <c>false</c>
        ///     otherwise. As an output parameter.
        /// </param>
        public void Intersects(ref RectangleF value, out bool result)
        {
            result = value.Left < this.Right && this.Left < value.Right && value.Top < this.Bottom
                     && this.Top < value.Bottom;
        }

        /// <summary>
        ///     returns true if other intersects rect
        /// </summary>
        /// <param name="other">other.</param>
        public bool Intersects(ref RectangleF other)
        {
            this.Intersects(ref other, out var result);
            return result;
        }

        /// <summary>
        ///     Creates a new <see cref="RectangleF" /> that contains overlapping region of two other rectangles.
        /// </summary>
        /// <param name="value1">The first <see cref="RectangleF" />.</param>
        /// <param name="value2">The second <see cref="RectangleF" />.</param>
        /// <returns>Overlapping region of the two rectangles.</returns>
        public static RectangleF Intersect(RectangleF value1, RectangleF value2)
        {
            Intersect(ref value1, ref value2, out var rectangle);
            return rectangle;
        }

        /// <summary>
        ///     Creates a new <see cref="RectangleF" /> that contains overlapping region of two other rectangles.
        /// </summary>
        /// <param name="value1">The first <see cref="RectangleF" />.</param>
        /// <param name="value2">The second <see cref="RectangleF" />.</param>
        /// <param name="result">Overlapping region of the two rectangles as an output parameter.</param>
        public static void Intersect(ref RectangleF value1, ref RectangleF value2, out RectangleF result)
        {
            if (value1.Intersects(value2))
            {
                var rightSide = Math.Min(value1.X + value1.Width, value2.X + value2.Width);
                var leftSide = Math.Max(value1.X, value2.X);
                var topSide = Math.Max(value1.Y, value2.Y);
                var bottomSide = Math.Min(value1.Y + value1.Height, value2.Y + value2.Height);
                result = new RectangleF(leftSide, topSide, rightSide - leftSide, bottomSide - topSide);
            }
            else
            {
                result = new RectangleF(0, 0, 0, 0);
            }
        }

        /// <summary>
        ///     Changes the <see cref="Location" /> of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="offsetX">The x coordinate to add to this <see cref="RectangleF" />.</param>
        /// <param name="offsetY">The y coordinate to add to this <see cref="RectangleF" />.</param>
        public void Offset(int offsetX, int offsetY)
        {
            this.X += offsetX;
            this.Y += offsetY;
        }

        /// <summary>
        ///     Changes the <see cref="Location" /> of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="offsetX">The x coordinate to add to this <see cref="RectangleF" />.</param>
        /// <param name="offsetY">The y coordinate to add to this <see cref="RectangleF" />.</param>
        public void Offset(float offsetX, float offsetY)
        {
            this.X += offsetX;
            this.Y += offsetY;
        }

        /// <summary>
        ///     Changes the <see cref="Location" /> of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="amount">The x and y components to add to this <see cref="RectangleF" />.</param>
        public void Offset(Point amount)
        {
            this.X += amount.X;
            this.Y += amount.Y;
        }

        /// <summary>
        ///     Changes the <see cref="Location" /> of this <see cref="RectangleF" />.
        /// </summary>
        /// <param name="amount">The x and y components to add to this <see cref="RectangleF" />.</param>
        public void Offset(Vector2 amount)
        {
            this.X += amount.X;
            this.Y += amount.Y;
        }

        /// <summary>
        ///     Returns a <see cref="String" /> representation of this <see cref="RectangleF" /> in the format:
        ///     {X:[<see cref="X" />] Y:[<see cref="Y" />] Width:[<see cref="Width" />] Height:[<see cref="Height" />]}
        /// </summary>
        /// <returns><see cref="String" /> representation of this <see cref="RectangleF" />.</returns>
        public override string ToString()
        {
            return $"X:{this.X}, Y:{this.Y}, Width: {this.Width}, Height: {this.Height}";
        }

        /// <summary>
        ///     Creates a new <see cref="RectangleF" /> that completely contains two other rectangles.
        /// </summary>
        /// <param name="value1">The first <see cref="RectangleF" />.</param>
        /// <param name="value2">The second <see cref="RectangleF" />.</param>
        /// <returns>The union of the two rectangles.</returns>
        public static RectangleF Union(RectangleF value1, RectangleF value2)
        {
            var x = Math.Min(value1.X, value2.X);
            var y = Math.Min(value1.Y, value2.Y);
            return new RectangleF(
                x,
                y,
                Math.Max(value1.Right, value2.Right) - x,
                Math.Max(value1.Bottom, value2.Bottom) - y);
        }

        /// <summary>
        ///     Creates a new <see cref="RectangleF" /> that completely contains two other rectangles.
        /// </summary>
        /// <param name="value1">The first <see cref="RectangleF" />.</param>
        /// <param name="value2">The second <see cref="RectangleF" />.</param>
        /// <param name="result">The union of the two rectangles as an output parameter.</param>
        public static void Union(ref RectangleF value1, ref RectangleF value2, out RectangleF result)
        {
            result.X = Math.Min(value1.X, value2.X);
            result.Y = Math.Min(value1.Y, value2.Y);
            result.Width = Math.Max(value1.Right, value2.Right) - result.X;
            result.Height = Math.Max(value1.Bottom, value2.Bottom) - result.Y;
        }

        #endregion

        #region Operators

        /// <summary>
        ///     Compares whether two <see cref="RectangleF" /> instances are equal.
        /// </summary>
        /// <param name="a"><see cref="RectangleF" /> instance on the left of the equal sign.</param>
        /// <param name="b"><see cref="RectangleF" /> instance on the right of the equal sign.</param>
        /// <returns><c>true</c> if the instances are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(RectangleF a, RectangleF b)
        {
            return a.X == b.X && a.Y == b.Y && a.Width == b.Width && a.Height == b.Height;
        }

        /// <summary>
        ///     Compares whether two <see cref="RectangleF" /> instances are not equal.
        /// </summary>
        /// <param name="a"><see cref="RectangleF" /> instance on the left of the not equal sign.</param>
        /// <param name="b"><see cref="RectangleF" /> instance on the right of the not equal sign.</param>
        /// <returns><c>true</c> if the instances are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(RectangleF a, RectangleF b)
        {
            return !(a == b);
        }

        public static implicit operator Rectangle(RectangleF self)
        {
            return new Rectangle((int)self.X, (int)self.Y, (int)self.Width, (int)self.Height);
        }

        public static implicit operator RectangleF(Rectangle self)
        {
            return new RectangleF(self.X, self.Y, self.Width, self.Height);
        }

        #endregion

        internal string DebugDisplayString => string.Concat(this.X, "  ", this.Y, "  ", this.Width, "  ", this.Height);
    }
}