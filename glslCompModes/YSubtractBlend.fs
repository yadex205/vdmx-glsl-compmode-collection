vec4 CompositeBottomAndTop(vec4 bottom, float bottomAlpha, vec4 top, float topAlpha) {
  vec4 outputTop = vec4(topAlpha) * top;
  vec4 outputBlended = (vec4(bottomAlpha) * bottom) - outputTop;
  vec4 returnMe = mix(outputTop, outputBlended, bottomAlpha * bottom.a);
  returnMe.a = 1.0;
  return returnMe;
}

vec4 CompositeBottom(vec4 bottom, float bottomAlpha) {
  vec4 returnMe = vec4(bottomAlpha) * bottom;
  returnMe.a = 1.0;
  return returnMe;
}

vec4 CompositeTop(vec4 top, float topAlpha) {
  vec4 returnMe = vec4(topAlpha) * top;
  returnMe.a = 1.0;
  return returnMe;
}
